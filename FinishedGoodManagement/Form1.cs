using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinishedGoodManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime.Parse(dateTimePicker1.Text);
            }
            catch
            {
                dateTimePicker1.Text = DateTime.Today.ToShortDateString();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime.Parse(dateTimePicker1.Text);
            }
            catch
            {
                dateTimePicker1.Text = DateTime.Today.ToShortDateString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //var Email = new FormPopoup();
            //Email.Show(this);
        }
    }
}
