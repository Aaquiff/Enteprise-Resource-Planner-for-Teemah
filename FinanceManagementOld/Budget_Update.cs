using MetroFramework.Forms;
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

namespace FinanceManagement
{
    public partial class Budget_Update : MetroForm
    {
        double ptot;
        double pemployee = 0;
        double pmaintanance = 0;
        double pmarketing = 0;
        double ptransport = 0;
        public Budget_Update()
        {
            InitializeComponent();
        }

        /*private void button_delete_Click(object sender, EventArgs e)
        {
            String message = "";
            try
            {
                int pbudgetYear = 0;
                pemployee = Convert.ToDouble(textBox_employee.Text);
                pmaintanance = Convert.ToDouble(textBox_maintanance.Text);
                pmarketing = Convert.ToDouble(textBox_marketing.Text);
                ptransport = Convert.ToDouble(textBox_transport.Text);
                String pstartdate = dateTimePicker_Budget.Value.ToString("yyyy-MM-dd");
                String penddate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                String pdescription = "";

                if (IsDigit(textBox_budgetid.Text))
                {
                    pbudgetYear = Convert.ToInt32(textBox_budgetid.Text);
                    if ((pbudgetYear > 1900) && (pbudgetYear < 2100))
                    {

                    }
                    else
                        message += "Valid Budget Year\n";
                }
                else
                    message += "Valid Budget Year\n";

                if (!IsDigit(textBox_employee.Text))
                    message += "Employee Cost\n";

                if (!IsDigit(textBox_maintanance.Text))
                    message += "Maintanance Cost\n";

                if (!IsDigit(textBox_transport.Text))
                    message += "Transport Cost\n";

                if (!IsDigit(textBox_marketing.Text))
                    message += "Marketing Cost\n";

                if (String.IsNullOrWhiteSpace(richTextBox_description.Text) || richTextBox_description.Text == "Type all other wanted details here")
                    message += "Description\n";
                else
                    pdescription = richTextBox_description.Text;

                /* if (IsDigit(textBox_total.Text))
                     pamount = Convert.ToDouble(textBox_total.Text);
                 else
                     message += "Total\n";*/
               /* ptot = pemployee + pmaintanance + pmarketing + ptransport;
                textBox_total.Text = ptot.ToString();

                if (message == "")
                {
                    DialogResult result;
                    result = MessageBox.Show("Do you want to Proceed?", "Please confirm the update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            DBConnects connection = new DBConnects();
                            connection.OpenConnection();

                            MySqlConnection returnConn = new MySqlConnection();
                            returnConn = connection.GetConnection();

                            string query = "UPDATE fms_budget SET Budget_Start_Date='" + pstartdate + "', Budget_End_Date='" + penddate + "', Employee_Cost='" + textBox_employee.Text + "', Maintanance_Cost='" + textBox_maintanance.Text + "', Marketing_Cost='" + textBox_marketing.Text + "', Transport_Cost='" + textBox_transport.Text + "', Description='" + richTextBox_description.Text + "', Total_Value='" + textBox_total.Text + "' where Budget_Year='" + textBox_budgetid.Text + "'";

                            MySqlCommand cmd = new MySqlCommand(query, returnConn);
                            cmd.Connection = returnConn;
                            cmd.ExecuteNonQuery();
                            connection.CloseConnection();
                            MessageBox.Show("Budget information updated");

                            FillGrid();
                            //refresh
                            comboBox_property.SelectedItem = -1;
                            textBox_serialnumber.Clear();
                            textBox_ownership.Clear();
                            textBox_value.Clear();
                            checkBox_insurance.Checked = false;
                            checkBox_warranty.Checked = false;
                            checkBox_status.Checked = false;
                            textBox_lifetime.Clear();
                            textBox_usage.Clear();
                            richTextBox_description.Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                    MessageBox.Show("" + message, "Please Provide", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[rowindex];
            String cclick = Convert.ToString(selectedRow.Cells["Budget_Year"].Value);
            textBox_budgetid.Text = cclick;        }

        private void textBox_budgetid_TextChanged(object sender, EventArgs e)
        {
            if (IsDigit(textBox_budgetid.Text))
            {
                int pbudgetYear = Convert.ToInt32(textBox_budgetid.Text);
                if ((pbudgetYear > 1900) && (pbudgetYear < 2100))
                    errorProvider1.Clear();
                else
                    errorProvider1.SetError(textBox_budgetid, "Enter a Year");


            }
            else
                errorProvider1.SetError(textBox_budgetid, "Enter a Year");
          
            try
            {

                DBConnects connection = new DBConnects();
                connection.OpenConnection();

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "SELECT * FROM fms_budget WHERE Budget_Year = '" + textBox_budgetid.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, returnConn);

                try
                {

                    using (MySqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            dateTimePicker_Budget.Text = read.GetString("Budget_Start_Date").ToString();
                            dateTimePicker1.Text = read.GetString("Budget_End_Date").ToString();
                            textBox_employee.Text = read.GetString("Employee_Cost").ToString();
                            textBox_maintanance.Text = read.GetString("Maintanance_Cost").ToString();
                            textBox_marketing.Text = read.GetString("Marketing_Cost").ToString();
                            textBox_transport.Text = read.GetString("Transport_Cost").ToString();
                            richTextBox_description.Text = read.GetString("Description").ToString();
                            textBox_total.Text = read.GetString("Total_Value").ToString();
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool IsDigit(String temp)
        {
            bool result = false;
            for (int i = 0; i < temp.Length; i++)
            {
                char c = temp[i];
                if (c >= '0' && c <= '9')
                    result = true;

                else
                {
                    result = false;
                    break;
                }


            }
            return result;
        }

        public void FillGrid()
        {
            FinManagement dba = new FinManagement();
            DataSet ds = dba.getAll("fms_budget");
            dataGridView1.DataSource = ds.Tables["fms_budget"].DefaultView;
        }

        private void Budget_Update_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void dataGridView1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[rowindex];
            String cclick = Convert.ToString(selectedRow.Cells["budget"].Value);
            textBox_budgetid.Text = cclick;
        }

        private void dateTimePicker_Budget_ValueChanged(object sender, EventArgs e)
        {
            /*dateTimePicker_Budget.MinDate = DateTime.Now;
            dateTimePicker1.MinDate = dateTimePicker_Budget.Value.AddYears(1);*/
        }

        private void button_back_Click_1(object sender, EventArgs e)
        {
            this.Close();
            BudgetManagement budget = new BudgetManagement();
            budget.Show();
        }

        private void button_delete_Click_1(object sender, EventArgs e)
        {
            String message = "";
            try
            {
                int pbudgetYear = 0;
                pemployee = Convert.ToDouble(textBox_employee.Text);
                pmaintanance = Convert.ToDouble(textBox_maintanance.Text);
                pmarketing = Convert.ToDouble(textBox_marketing.Text);
                ptransport = Convert.ToDouble(textBox_transport.Text);
                String pstartdate = dateTimePicker_Budget.Value.ToString("yyyy-MM-dd");
                String penddate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                String pdescription = "";

                if (IsDigit(textBox_budgetid.Text))
                {
                    pbudgetYear = Convert.ToInt32(textBox_budgetid.Text);
                    if ((pbudgetYear > 1900) && (pbudgetYear < 2100))
                    {

                    }
                    else
                        message += "Valid Budget Year\n";
                }
                else
                    message += "Valid Budget Year\n";

                if (!IsDigit(textBox_employee.Text))
                    message += "Employee Cost\n";

                if (!IsDigit(textBox_maintanance.Text))
                    message += "Maintanance Cost\n";

                if (!IsDigit(textBox_transport.Text))
                    message += "Transport Cost\n";

                if (!IsDigit(textBox_marketing.Text))
                    message += "Marketing Cost\n";

                if (String.IsNullOrWhiteSpace(richTextBox_description.Text) || richTextBox_description.Text == "Type all other wanted details here")
                    message += "Description\n";
                else
                    pdescription = richTextBox_description.Text;

                ptot = pemployee + pmaintanance + pmarketing + ptransport;
                textBox_total.Text = ptot.ToString();

                if (message == "")
                {
                    DialogResult result;
                    result = MessageBox.Show("Do you want to Proceed?", "Please confirm the update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            DBConnects connection = new DBConnects();
                            connection.OpenConnection();

                            MySqlConnection returnConn = new MySqlConnection();
                            returnConn = connection.GetConnection();

                            string query = "UPDATE fms_budget SET Budget_Start_Date='" + pstartdate + "', Budget_End_Date='" + penddate + "', Employee_Cost='" + textBox_employee.Text + "', Maintanance_Cost='" + textBox_maintanance.Text + "', Marketing_Cost='" + textBox_marketing.Text + "', Transport_Cost='" + textBox_transport.Text + "', Description='" + richTextBox_description.Text + "', Total_Value='" + textBox_total.Text + "' where Budget_Year='" + textBox_budgetid.Text + "'";

                            MySqlCommand cmd = new MySqlCommand(query, returnConn);
                            cmd.Connection = returnConn;
                            cmd.ExecuteNonQuery();
                            connection.CloseConnection();
                            MessageBox.Show("Budget information updated");

                            FillGrid();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                    MessageBox.Show("" + message, "Please Provide", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_refresh_Click_1(object sender, EventArgs e)
        {
            FillGrid();
        }

    }
}
