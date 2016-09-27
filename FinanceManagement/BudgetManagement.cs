using MetroFramework;
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
    public partial class BudgetManagement : Form
    {
        double ptot = 0;
        double pemployee = 0;
        double pmaintanance = 0;
        double pmarketing = 0;
        double ptransport = 0;

        public BudgetManagement()
        {
            InitializeComponent();
        }

        private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_tittle_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            FinanceManagementDashBoard finance = new FinanceManagementDashBoard();
            finance.Show();

        }

        private void BudgetManagement_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        public void FillGrid()
        {
            FinManagement dba = new FinManagement();
            DataSet ds = dba.getAll("fms_budget");
            dataGridView1.DataSource = ds.Tables["fms_budget"].DefaultView;
        }


        public void FillSpecific()
        {
            String pbudgetyear;
            pbudgetyear = textBox_budgetid.Text;
            FinManagement dba = new FinManagement();
            DataSet ds = dba.getSpecificBID("fms_budget", pbudgetyear);
            dataGridView1.DataSource = ds.Tables["fms_budget"].DefaultView;
        }

        //checking whether a string value contains all digits
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

        private void richTextBox_description_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_total_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox_description_Click(object sender, EventArgs e)
        {
            richTextBox_description.Clear();
        }

        private void textBox_budgetid_TextChanged(object sender, EventArgs e)
        {

            if (IsDigit(textBox_budgetid.Text))
            {
                int pbudgetYear = Convert.ToInt32(textBox_budgetid.Text);
                if ((pbudgetYear > 1900) && (pbudgetYear < 2100))
                {
                    errorProvider1.Clear();
                    FillSpecific();
                }
                else
                    errorProvider1.SetError(textBox_budgetid, "Enter a Year");


            }
            else
                errorProvider1.SetError(textBox_budgetid, "Enter a Year");

        }

        private void textBox_specification_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_employee_TextChanged(object sender, EventArgs e)
        {
            //pemployee = Convert.ToDouble(textBox_employee.Text);
            //ptot = pemployee + pmaintanance + pmarketing + ptransport;
            //textBox_total.Text = ptot.ToString();
        }

        private void textBox_maintanance_TextChanged(object sender, EventArgs e)
        {
            //pmaintanance = Convert.ToDouble(textBox_employee.Text);
            //ptot = pemployee + pmaintanance + pmarketing + ptransport;
            //textBox_total.Text = ptot.ToString();
        }

        private void textBox_marketing_TextChanged(object sender, EventArgs e)
        {
            //pmarketing = Convert.ToDouble(textBox_employee.Text);
            //ptot = pemployee + pmaintanance + pmarketing + ptransport;
            //textBox_total.Text = ptot.ToString();
        }

        private void textBox_transport_TextChanged(object sender, EventArgs e)
        {
            //ptransport = Convert.ToDouble(textBox_employee.Text);
            //ptot = pemployee + pmaintanance + pmarketing + ptransport;
            //textBox_total.Text = ptot.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Budget_Update update = new Budget_Update();
            update.Show();
        }

        private void dateTimePicker_Budget_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_Budget.MinDate = DateTime.Now;
            dateTimePicker1.MinDate = dateTimePicker_Budget.Value.AddYears(1);
        }

        private void button_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FinanceManagementDashBoard finance = new FinanceManagementDashBoard();
            finance.Show();
        }

        private void button_add_Click_1(object sender, EventArgs e)
        {
            String message = "";
            try
            {
                int pbudgetYear = 0;
                pemployee = Convert.ToDouble(textBox_employee.Text);
                pmaintanance = Convert.ToDouble(textBox_maintanance.Text);
                pmarketing = Convert.ToDouble(textBox_marketing.Text);
                ptransport = Convert.ToDouble(textBox_transport.Text);
                String pdescription = "";
                String pstartdate = dateTimePicker_Budget.Value.ToString("yyyy-MM-dd");
                String penddate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
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
                    result = MetroMessageBox.Show(this,"You wish to Continue?", "Valid Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        FinManagement fin = new FinManagement();
                        fin.addBudget(pbudgetYear, pstartdate, penddate, pemployee, pmaintanance, pmarketing, ptransport, pdescription, ptot);
                    }

                }
                else
                    MetroMessageBox.Show(this,"" + message, "Please Provide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FillGrid();
            }

            catch (Exception ex)
            {
                MetroMessageBox.Show(this,ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FillSpecific();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            //this.Close();
            Budget_Update update = new Budget_Update();
            update.ShowDialog();
        }

        private void button_refresh_Click_1(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
        }


    }
}
