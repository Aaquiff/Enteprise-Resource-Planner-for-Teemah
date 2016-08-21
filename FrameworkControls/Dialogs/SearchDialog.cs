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

namespace FrameworkControls.Dialogs
{
    public partial class SearchDialog : Form
    {
        MySqlConnection con;
        MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
        DataSet dataSet = new DataSet();
        BindingSource bindingSource = new BindingSource();

        public SearchDialog()
        {
            InitializeComponent();
        }

        public SearchDialog(MySqlCommand sc)
        {
            InitializeComponent();

            dataAdapter.SelectCommand = sc;
            dataAdapter.Fill(dataSet);

            foreach (DataColumn item in dataSet.Tables[0].Columns)
            {
                FlowLayoutPanel p = new FlowLayoutPanel();
                p.BackColor = Color.White;
                p.Height = 30;
                p.Dock = DockStyle.Top;
                Label l = new Label();
                l.Text = item.ToString().Replace("_"," ").ToUpper();
                TextBox t = new TextBox();
                t.Anchor = AnchorStyles.Right;
                t.Width = 200;

                p.Controls.Add(l);
                p.Controls.Add(t);
 
                this.panel1.Controls.Add(p);                
            }
        }
    }
}
