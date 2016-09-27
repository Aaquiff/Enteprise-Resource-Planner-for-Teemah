using MetroFramework;
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
    public partial class Expenses_Update : MetroForm
    {
        public Expenses_Update()
        {
            InitializeComponent();
        }

        public void FillGrid()
        {
            FinManagement dba = new FinManagement();
            DataSet ds = dba.getAll("fms_expenses");
            dataGridView1.DataSource = ds.Tables["fms_expenses"].DefaultView;
        }

        private void Expenses_Update_Load(object sender, EventArgs e)
        {
            FillGrid();
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

        private void textBox_budgetyear_TextChanged(object sender, EventArgs e)
        {
            if (IsDigit(textBox_budgetyear.Text))
            {
                double pbudgetyear = Convert.ToInt32(textBox_budgetyear.Text);
                if ((pbudgetyear > 1900) && (pbudgetyear < 2100))
                    errorProvider1.Clear();
                else
                    errorProvider1.SetError(textBox_budgetyear, "Enter a Year");
            }
            else
                errorProvider1.SetError(textBox_budgetyear, "Enter a Year");
        }

        private void textBox_ecount_TextChanged(object sender, EventArgs e)
        {
            try
            {

                DBConnects connection = new DBConnects();
                connection.OpenConnection();

                MySqlConnection returnConn = new MySqlConnection();
                returnConn = connection.GetConnection();

                string query = "SELECT * FROM fms_expenses WHERE ECount = '" + textBox_ecount.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, returnConn);

                try
                {

                    using (MySqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            textBox_budgetyear.Text = read.GetString("Budget_Year").ToString();
                            textBox_aproved.Text = read.GetString("Aproved_By").ToString();
                            comboBox_category.Text = read.GetString("Expense_Category").ToString();
                            textBox_specification.Text = read.GetString("Expense_Specification").ToString();
                            textBox_amount.Text = read.GetString("Expense_Amount").ToString();
                            dateTimePicker1.Text = read.GetString("Expense_Date").ToString();
                            richTextBox_description.Text = read.GetString("Description").ToString();
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

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[rowindex];
            String cclick = Convert.ToString(selectedRow.Cells["number"].Value);
            textBox_ecount.Text = cclick;
        }

        private void button_back_Click_1(object sender, EventArgs e)
        {
            this.Close();
            ExpensesManagement expense = new ExpensesManagement();
            expense.Show();
        }

        private void button_update_Click_1(object sender, EventArgs e)
        {
            String message = "";
            try
            {
                int pbudgetyear = 0;
                String paproved = textBox_aproved.Text;
                String pcategory = "";
                String pspecification = textBox_specification.Text;
                double pamount = 0;
                String pdate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                String pdescription = richTextBox_description.Text;

                if (IsDigit(textBox_budgetyear.Text))
                {
                    pbudgetyear = Convert.ToInt32(textBox_budgetyear.Text);
                    if ((pbudgetyear > 1900) && (pbudgetyear < 2100))
                    {

                    }
                    else
                        message += "Valid Budget Year\n";
                }
                else
                    message += "Valid Budget Year\n";

                if (String.IsNullOrWhiteSpace(paproved) || (IsDigit(paproved)) || paproved == "" || paproved == " ")
                    message += "Aproved\n";

                if (comboBox_category.SelectedIndex == -1)
                    message += "Category\n";
                else
                    pcategory = comboBox_category.SelectedItem.ToString();

                if (IsDigit(pspecification) || String.IsNullOrWhiteSpace(pspecification) || pspecification == " " || pspecification == "")
                    message += "Specification\n";

                if (IsDigit(textBox_amount.Text))
                {
                    if (Convert.ToDouble(textBox_amount.Text) == 0)
                        message += "Amount\n";
                    else
                        pamount = Convert.ToDouble(textBox_amount.Text);
                }
                else
                    message += "Amount\n";

                if (String.IsNullOrWhiteSpace(richTextBox_description.Text) || richTextBox_description.Text == "Type all other wanted details here")
                    message += "Description\n";
                else
                    pdescription = richTextBox_description.Text;


                if (message == "")
                {
                    DialogResult result;
                    result = MetroMessageBox.Show(this,"Do you want to Proceed?", "Please confirm the update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            DBConnects connection = new DBConnects();
                            connection.OpenConnection();

                            MySqlConnection returnConn = new MySqlConnection();
                            returnConn = connection.GetConnection();

                            string query = "UPDATE fms_expenses SET Aproved_By='" + paproved + "', Expense_Category='" + pcategory + "', Expense_Specification='" + pspecification + "', Expense_Amount='" + pamount + "', Expense_Date='" + pdate + "', Description='" + richTextBox_description.Text + "' where ECount='" + textBox_ecount.Text + "'";

                            MySqlCommand cmd = new MySqlCommand(query, returnConn);
                            cmd.Connection = returnConn;
                            cmd.ExecuteNonQuery();
                            connection.CloseConnection();
                            MetroMessageBox.Show(this,"Expense information updated");

                            FillGrid();
                        }
                        catch (Exception ex)
                        {
                            MetroMessageBox.Show(this,ex.Message);
                        }
                    }
                }
                else
                    MetroMessageBox.Show(this,"" + message, "Please Provide", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this,ex.Message);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FillGrid();
        }
    }
}
