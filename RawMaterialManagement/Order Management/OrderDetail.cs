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
using MySql.Data;

namespace RawMaterialManagement.Order_Management
{
    public partial class OrderDetail : Form
    {
        #region properties

        MySqlConnection con;
        MySqlDataAdapter orderAdapter;
        BindingSource orderBindingSource = new BindingSource();
        DataSet orderDataSet = new DataSet();

        #endregion

        public OrderDetail()
        {
            InitializeComponent();

            con = Connection.getConnection();
            orderAdapter = new MySqlDataAdapter("select * from raw_purchase_order_tab", con);

            /*MySqlCommand insertCommand = new MySqlCommand("insert into raw_item_tab values (@itemid,@name,@description,@stock_level,@unit_of_measure)", con);
            insertCommand.Parameters.Add("@itemid", MySqlDbType.VarChar, 200, "item_id");
            insertCommand.Parameters.Add("@name", MySqlDbType.VarChar, 2000, "name");
            insertCommand.Parameters.Add("@description", MySqlDbType.VarChar, 2000, "description");
            insertCommand.Parameters.Add("@stock_level", MySqlDbType.Int32, 11, "stock_level");
            insertCommand.Parameters.Add("@unit_of_measure", MySqlDbType.VarChar, 20, "unit_of_measure");

            orderAdapter.InsertCommand = insertCommand;

            MySqlCommand updateCommand = new MySqlCommand("update raw_item_tab set name = @itemname, description = @description, stock_level = @stock_level, unit_of_measure = @unit_of_measure where item_id = @itemid", con);
            updateCommand.Parameters.Add("@itemname", MySqlDbType.VarChar, 200, "name");
            updateCommand.Parameters.Add("@description", MySqlDbType.VarChar, 2000, "description");
            updateCommand.Parameters.Add("@stock_level", MySqlDbType.Int32, 11, "stock_level");
            updateCommand.Parameters.Add("@unit_of_measure", MySqlDbType.VarChar, 20, "unit_of_measure");
            updateCommand.Parameters.Add("@itemid", MySqlDbType.VarChar, 200, "item_id");

            orderAdapter.UpdateCommand = updateCommand;

            MySqlCommand deleteCommand = new MySqlCommand("delete from raw_item_tab where item_id = @itemid", con);
            deleteCommand.Parameters.Add("@itemid", MySqlDbType.VarChar, 200, "item_id");
            
            orderAdapter.DeleteCommand = deleteCommand;*/
            orderAdapter.Fill(orderDataSet);
            dataGridViewNavigator.DataSource = orderDataSet.Tables[0];
        }

        public OrderDetail(string orderid)
        {
            InitializeComponent();
            /*con = Connection.getConnection();
            orderAdapter = new MySqlDataAdapter("select * from raw_purchase_order_tab where order_id = '" + orderid + "'", con);
            orderAdapter.Fill(orderDataSet);
            orderBindingSource.DataSource = orderDataSet.Tables[0];
            
            DataRowView row = orderBindingSource.Current as DataRowView;*/
            //continue from here
        }

        #region methods

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (orderDataSet.HasChanges())
            {
                switch (MessageBox.Show(this, "Do you want to save your changes?", "Closing", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.No:
                        break;
                    case DialogResult.Yes:
                        Save();
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }

        }

        private void Save()
        {
            try
            {
                this.Validate();
                orderAdapter.Update(orderDataSet);
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete()
        {
            try
            {
                orderBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Populate()
        {
            try
            {
                orderDataSet.Clear();
                orderAdapter.Fill(orderDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void New()
        {
            try
            {
                orderBindingSource.AddNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void dataGridViewNavigator_SelectionChanged(object sender, EventArgs e)
        {
            DataRowView row = orderBindingSource.Current as DataRowView;
            //MessageBox.Show(dataGridViewNavigator.CurrentRow);
        }
    }
}
