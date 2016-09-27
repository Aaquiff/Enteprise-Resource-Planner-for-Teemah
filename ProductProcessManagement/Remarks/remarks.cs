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

namespace ProductProcessManagement
{
    public partial class remarks : Form
    {

        private string TQuery;
        public remarks()
        {
            InitializeComponent();
            TQuery = "SELECT remarkId as 'Remark Id',title as 'Title',status as 'Status',priority as 'Priority',created as 'Created',notes as 'Notes',archived as 'Is Archived' from remarks";
            clearFilters();
            bindResults();
            resizeWindowD();
        }

        private void resizeWindow(object sender, EventArgs e)
        {
            resizeWindowD();
        }

        private void resizeWindowD()
        {
            //tableLayoutPanel1.Width = (int)(this.Width * 1684 / 1920) - 15;
            //tableLayoutPanel1.Height = (int)(this.Height * 948 / 1080) - 15;
            //tableLayoutPanel1.Location = new Point((int)((this.Width * 236 / 1920)), (int)((this.Height * 132 / 1080)));
            tableLayoutPanel1.AutoScroll = true;
            //tableLayoutPanel1.AutoScrollPosition = new Point(0,0);


        }


        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "Title....") {
                textBoxTitle.Text = "";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "")
            {
                textBoxTitle.Text = "Title....";
            }
        }

        private void clearFilters() {
            comboBoxStatus.Text = "Any Status";
            comboBoxPriority.Text = "Any Priority";
            textBoxTitle.Text = "Title....";
            textBoxReference.Text = "";
            monthCalendar1.SetDate(DateTime.Now.AddMonths(-1));
            monthCalendar2.SetDate(DateTime.Now);

        
        }

        private void genFilterQuary() {
            string query = "SELECT remarkId as 'Remark Id',title as 'Title',status as 'Status',priority as 'Priority',created as 'Created',notes as 'Notes',archived as 'Is Archived' FROM remarks where";
            if (textBoxTitle.Text != "Title...." && textBoxTitle.Text != "")
            {
                query += " title LIKE '%" + textBoxTitle.Text + "%'";
            }
            if (comboBoxStatus.Text != "Any Status")
            {
                if (textBoxTitle.Text != "Title...." && textBoxTitle.Text != "")
                {
                    query += " and";
                }
                query += " status = '" + comboBoxStatus.Text + "'";
            }
            if (comboBoxPriority.Text != "Any Priority")
            {
                if ((textBoxTitle.Text != "Title...." && textBoxTitle.Text != "") || (comboBoxStatus.Text != "Any Status"))
                {
                    query += " and";
                }
                query += " priority = '" + comboBoxPriority.Text + "'";
            }

            if (((textBoxTitle.Text != "Title...." && textBoxTitle.Text != "") || (comboBoxStatus.Text != "Any Status") || (comboBoxPriority.Text != "Any Priority")))
            {
                query += " and";
            }
            query += " created between '" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "' and '" + monthCalendar2.SelectionRange.Start.ToString("yyyy-MM-dd") + "'";
            //MessageBox.Show(query);
            TQuery = query;
        
        }


        private void bindResults() {
            //Sql to runTquery and display results
            try
            {
                DBConnect conn = new DBConnect();
                conn.OpenConnection();
                string query = "";

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = conn.GetConnection();

                query = TQuery;

                //cmd.ExecuteNonQuery();
                MySqlCommand cmd = new MySqlCommand(query, returnConn);

                DataTable dt = new DataTable();
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                ada.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.CloseConnection();
            }

            catch (Exception ex)
            {
                //MessageBox.Show("Something went wrong while laoding products!");
                MessageBox.Show(ex.Message);
            }
        
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearFilters();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            genFilterQuary();
            bindResults();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxReference.Text == "") {
                MessageBox.Show("Please enter a Reference Id");
            }
            else
            {
                TQuery = "SELECT remarkId as 'Remark Id',title as 'Title',status as 'Status',priority as 'Priority',created as 'Created',notes as 'Notes',archived as 'Is Archived' FROM remarks WHERE remarkId = " + textBoxReference.Text;
                bindResults();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //High Priority Remakrs
            TQuery = "SELECT remarkId as 'Remark Id',title as 'Title',status as 'Status',priority as 'Priority',created as 'Created',notes as 'Notes',archived as 'Is Archived' FROM remarks WHERE priority > 7 and status = 'Not Reviewed' and archived = 0 and created between '" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "' and '" + monthCalendar2.SelectionRange.Start.ToString("yyyy-MM-dd") + "'";
            //MessageBox.Show(TQuery);
            bindResults();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Not Reviewed Remarks
            TQuery = "SELECT remarkId as 'Remark Id',title as 'Title',status as 'Status',priority as 'Priority',created as 'Created',notes as 'Notes',archived as 'Is Archived' FROM remarks WHERE status = 'Not Reviewed' and archived = 0 and created between '" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "' and '" + monthCalendar2.SelectionRange.Start.ToString("yyyy-MM-dd") + "'";
            //MessageBox.Show(TQuery);
            bindResults();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Recently Archived Remarks
            TQuery = "SELECT remarkId as 'Remark Id',title as 'Title',status as 'Status',priority as 'Priority',created as 'Created',notes as 'Notes',archived as 'Is Archived' FROM remarks WHERE archived = 1 and created between '" + monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd") + "' and '" + monthCalendar2.SelectionRange.Start.ToString("yyyy-MM-dd") + "'";
            //MessageBox.Show(TQuery);
            bindResults();
        }

        private int getSelectedRemark()
        {
            int selected = dataGridView1.CurrentCell.RowIndex;
            var remarkId = -1;
            if (Int32.TryParse(dataGridView1.Rows[selected].Cells[0].Value.ToString(), out remarkId))
            {
                return remarkId;
            }
            else
            {
                //MessageBox.Show("Soemthing went wrong!");
                return -1;
            }
        }

        public void viewRemark() {
            if (getSelectedRemark() > -1)
            {
                Remarks.remark remarkWindow = new Remarks.remark(getSelectedRemark());
                remarkWindow.FormClosed += new FormClosedEventHandler(refreshWindow);
                remarkWindow.Show();
            }
            else
            {
                MessageBox.Show("Please Select a Remark!");
            }
        }

        void refreshWindow(object sender, FormClosedEventArgs e)
        {
            bindResults();
        }



        private void button8_Click(object sender, EventArgs e)
        {
            viewRemark();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
