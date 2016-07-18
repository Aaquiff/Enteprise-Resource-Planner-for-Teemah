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

namespace RawMaterialManagement.Items_Management
{
    public partial class dlgSearchItem : Form
    {
        String searchSql;
        
        AttributeCollection col = new AttributeCollection();
        

        MySqlParameterCollection paramCollection;

        public String SearchSql
        {
            get { return searchSql; }
        }
        public dlgSearchItem()
        {
            InitializeComponent();
            searchSql = "SELECT * FROM item_tab";
            
        }

        private void BuildSQL()
        {
            string itemid = txtItemId.Text;
            string itemname = txtItemName.Text;
            string description = txtDescription.Text;

            string sqlwhere = null;

            foreach (MySqlParameter item in paramCollection)
            {
                if(String.IsNullOrEmpty(sqlwhere))
                {
                    sqlwhere = " WHERE " +  item.ParameterName + " = " + item.Value;
                }
                else
                {
                    sqlwhere = sqlwhere + " AND " + item.ParameterName + " = " + item.Value;
                }
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtItemId.Text))
            {
                //paramCollection.Add("item_id", txtItemId.Text);
                paramCollection.AddWithValue("item_id", txtItemId.Text);
            }
            
            /*paramCollection.Add("item_name", txtItemName.Text);
            paramCollection.Add("description", txtDescription.Text);*/
            BuildSQL();
            //searchSql = searchSql + " WHERE item_id = '" + txtItemId.Text + "';";
            //this.DialogResult = System.Windows.Forms.DialogResult.OK;
            //this.Close();
        }
    }
}
