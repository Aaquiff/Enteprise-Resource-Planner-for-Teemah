using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySQLDatabaseAccess;

namespace RawMaterialManagement.Order_Management
{
    public partial class AddOrder : Form
    {
        MySqlConnection con;

        public AddOrder()
        {
            InitializeComponent();
            con = Connection.getConnection();
        }

        private void btnChooseSupplier_Click(object sender, EventArgs e)
        {
            dlgChooseSupplier dlg = new dlgChooseSupplier();
            dlg.ShowDialog();
            txtSupplierId.Text = dlg.SupplierId;
            txtSupplierName.Text = dlg.SupplierName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addOrder();
        }

        private void addOrder()
        {
            try
            {
                MySqlCommand command = new MySqlCommand
                    ("INSERT INTO raw_purchase_order_tab (order_id,creation_date,creator,status,shipping_address,supplier_id) VALUES (@order_id,@creation_date,@creator,@status,@shipping_address,@supplier_id)",con);
                command.Parameters.AddWithValue("@order_id", txtOrderId.Text);
                command.Parameters.AddWithValue("@creation_date", DateTime.Now);
                command.Parameters.AddWithValue("@creator", txtCreator.Text);
                command.Parameters.AddWithValue("@status", "Created");
                command.Parameters.AddWithValue("@shipping_address", txtShippingAddress.Text);
                command.Parameters.AddWithValue("@supplier_id", txtSupplierId.Text);
                con.Open();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Order Created");
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
