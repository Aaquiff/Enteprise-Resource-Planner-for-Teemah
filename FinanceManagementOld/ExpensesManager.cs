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
        public BudgetManagement()
        {
            InitializeComponent();
        }

        private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = comboBox_category.SelectedItem.ToString();
            MessageBox.Show(name);
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
    }
}
