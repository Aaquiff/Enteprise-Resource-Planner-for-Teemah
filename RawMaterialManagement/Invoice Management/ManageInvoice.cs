﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RawMaterialManagement.Invoice_Management
{
    public partial class ManageInvoice : FrameworkControls.Forms.TableWindowBase
    {
        public ManageInvoice()
        {
            InitializeComponent();

            MySqlCommand sc = new MySqlCommand("select * from raw_invoice_tab",con);
            base.dataAdapter.SelectCommand = sc;
            base.dataAdapter.Fill(dataSet);
            base.bindingSource.DataSource = dataSet.Tables[0];
            dataGridView1.DataSource = base.bindingSource;

            MySqlCommand ic = new MySqlCommand
                ("raw_insert_invoice(@invoice_id,@order_id,@due_date,@original_due_date,@net_value,@tax_value,@gross_value,@discount,@currency)",con);
            ic.Parameters.Add("@invoice_id",MySqlDbType.VarChar,20,"invoice_id");
            ic.Parameters.Add("@order_id", MySqlDbType.VarChar, 20, "order_id");
            ic.Parameters.Add("@due_date", MySqlDbType.Date, 20, "due_date");
            ic.Parameters.Add("@original_due_date", MySqlDbType.Date, 20, "original_due_date");
            ic.Parameters.Add("@net_value", MySqlDbType.Double, 200, "net_value");
            ic.Parameters.Add("@tax_value", MySqlDbType.Double, 200, "tax_value");
            ic.Parameters.Add("@gross_value", MySqlDbType.Double, 200, "gross_value");
            ic.Parameters.Add("@discount", MySqlDbType.Int32, 20, "discount");
            ic.Parameters.Add("@currency", MySqlDbType.VarChar, 20, "currency");
            base.dataAdapter.InsertCommand = ic;

            MySqlCommand uc = new MySqlCommand("raw_invoice_update(@invoice_id,@order_id,@due_date,@original_due_date,@net_value,@tax_value,@gross_value,@discount,@currency)", con);
            uc.Parameters.Add("@invoice_id", MySqlDbType.VarChar, 20, "invoice_id");
            uc.Parameters.Add("@order_id", MySqlDbType.VarChar, 20, "order_id");
            uc.Parameters.Add("@due_date", MySqlDbType.Date, 20, "due_date");
            uc.Parameters.Add("@original_due_date", MySqlDbType.Date, 20, "original_due_date");
            uc.Parameters.Add("@net_value", MySqlDbType.Double, 200, "net_value");
            uc.Parameters.Add("@tax_value", MySqlDbType.Double, 200, "tax_value");
            uc.Parameters.Add("@gross_value", MySqlDbType.Double, 200, "gross_value");
            uc.Parameters.Add("@discount", MySqlDbType.Int32, 20, "discount");
            uc.Parameters.Add("@currency", MySqlDbType.VarChar, 20, "currency");
            base.dataAdapter.UpdateCommand = uc;


            MySqlCommand dc = new MySqlCommand("raw_invoice_delete(@invoice_id)", con);
            dc.Parameters.Add("@invoice_id", MySqlDbType.VarChar, 20, "invoice_id");

            base.dataAdapter.DeleteCommand = dc;

            
        }

        protected override void Search()
        {
            string columnName = cmbColumns.SelectedItem.ToString();
            if (!String.IsNullOrEmpty(columnName))
            {
                MySqlDataAdapter search = new MySqlDataAdapter();
                MySqlCommand sc = new MySqlCommand("select * from raw_invoice_tab where " + columnName + " like @param", con);
                sc.Parameters.AddWithValue("@param", "%" + txtSearchItemId.Text + "%");
                search.SelectCommand = sc;
                dataSet.Clear();
                search.Fill(dataSet);
            }
        }
    }
}
