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

namespace FrameworkControls.Dialogs
{
    public partial class LOV : MetroFramework.Forms.MetroForm
    {
        MySqlConnection con;
        MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
        DataSet dataSet = new DataSet();
        BindingSource bindingSource = new BindingSource();

        public DataRowView selectedRow;
        
        public LOV()
        {
            InitializeComponent();
        }

        public LOV(MySqlCommand sc) : base()
        {
            InitializeComponent();
            dataAdapter.SelectCommand = sc;
            dataAdapter.Fill(dataSet);
            bindingSource.DataSource = dataSet.Tables[0];
            customDataGrid11.DataSource = bindingSource;
            customDataGrid11.ReadOnly = true;
        }

        private void Select()
        {
            selectedRow = bindingSource.Current as DataRowView;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Select();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            Select();
        }

        private void customDataGrid11_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Select();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Select();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void customDataGrid11_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Select();
        }
    }
}
