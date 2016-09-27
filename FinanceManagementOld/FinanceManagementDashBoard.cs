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
    public partial class FinanceManagementDashBoard : Form
    {
        public FinanceManagementDashBoard()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_budget_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button_expense_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExpensesManagement expenses = new ExpensesManagement();
            expenses.Show();
        }

        private void button_asset_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssetManagement asset = new AssetManagement();
            asset.Show();
            
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_budget_Click_1(object sender, EventArgs e)
        {
            BudgetManagement budget = new BudgetManagement();
            this.Hide();
            budget.Show();
        }
    }
}
