using MetroFramework;
using MetroFramework.Forms;
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
    public partial class ExpensesManagement : Form
    {
        
        public ExpensesManagement()
        {
            InitializeComponent();
        }

        public void FillSpecific()
        {
            String pbudgetyear;
            pbudgetyear = textBox_budgetyear.Text;
            FinManagement dba = new FinManagement();
            DataSet ds = dba.getSpecificBID("fms_expenses", pbudgetyear);
            dataGridView1.DataSource = ds.Tables["fms_expenses"].DefaultView;
        }

        public void FillGrid()
        {
            FinManagement dba = new FinManagement();
            DataSet ds = dba.getAll("fms_expenses");
            dataGridView1.DataSource = ds.Tables["fms_expenses"].DefaultView;
        }

        private void ExpensesManagement_Load(object sender, EventArgs e)
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

        private void richTextBox_description_Click(object sender, EventArgs e)
        {
            richTextBox_description.Clear();
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

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            FinanceManagementDashBoard finance = new FinanceManagementDashBoard();
            finance.Show();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            String message = "";
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
                message += "Approved\n";

            if (comboBox_category.SelectedIndex == -1)
                message += "Category\n";
            else
                pcategory = comboBox_category.SelectedItem.ToString();

            if (IsDigit(pspecification) || String.IsNullOrWhiteSpace(pspecification) || pspecification == " " || pspecification == "")
                message += "Specification\n";

            if (IsDigit(textBox_amount.Text))
            {
                if(Convert.ToDouble(textBox_amount.Text) == 0)
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
                result = MetroMessageBox.Show(this,"You wish to Continue?", "Valid Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FinManagement fin = new FinManagement();
                    fin.addExpenses(pbudgetyear, paproved, pcategory, pspecification, pamount, pdate, pdescription);
                    MetroMessageBox.Show(this, "New Expense added to the database");
                }

            }
            else
                MetroMessageBox.Show(this,"" + message, "Please Provide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            FillGrid();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (IsDigit(textBox_budgetyear.Text))
            {
                double pbudgetyear = Convert.ToInt32(textBox_budgetyear.Text);
                if ((pbudgetyear > 1900) && (pbudgetyear < 2100))
                {
                    FillSpecific();
                }
                else
                    MetroMessageBox.Show(this,"Please Enter the Budget Year");
            }
            else
                MetroMessageBox.Show(this,"Please Enter the Budget Year");
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            //this.Close();
            Expenses_Update expense = new Expenses_Update();
            expense.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void textBox_amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
