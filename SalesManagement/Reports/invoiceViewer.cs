using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class invoiceViewer : Form
    {
        public invoiceViewer()
        {
            InitializeComponent();
        }

        public invoiceViewer(string invoiceNum)
        {
            InitializeComponent();
            method1(invoiceNum);
            method2(invoiceNum);
        }

        private void invoiceViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetForInvoice.invoice' table. You can move, or remove it, as needed.
            //this.invoiceTableAdapter.Fill(this.DataSetForInvoice.invoice);
            // TODO: This line of code loads data into the 'DataSetForInvoice.proddetails' table. You can move, or remove it, as needed.
            //this.proddetailsTableAdapter.Fill(this.DataSetForInvoice.proddetails);
            // TODO: This line of code loads data into the 'DataSetForInvoice.invoice' table. You can move, or remove it, as needed.
            //this.invoiceTableAdapter.Fill(this.DataSetForInvoice.invoice);
            //// TODO: This line of code loads data into the 'DataSetForInvoice.proddetails' table. You can move, or remove it, as needed.
            //this.proddetailsTableAdapter.Fill(this.DataSetForInvoice.proddetails);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        public void method1(string invoiceNum)
        {
            DBConnect conn = new DBConnect();
            conn.OpenConnection();
            MySqlConnection returnConn = new MySqlConnection();
            returnConn = conn.GetConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM itp.invoice where invoiceNo = '" + invoiceNum + "'", returnConn);
            adapter.Fill(DataSetForInvoice.invoice);

        }

        public void method2(string invoiceNum)
        {
            DBConnect conn = new DBConnect();
            conn.OpenConnection();
            MySqlConnection returnConn = new MySqlConnection();
            returnConn = conn.GetConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM itp.proddetails where invoiceNo = '" + invoiceNum + "'", returnConn);
            adapter.Fill(DataSetForInvoice.proddetails);
            
            
        }
    }
}
