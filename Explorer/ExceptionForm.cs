using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explorer
{
    public partial class ExceptionForm : Form
    {
        public ExceptionForm()
        {
            InitializeComponent();
        }
        public ExceptionForm(Exception ex):this()
        {
            lblException.Text = ex.Message;
            this.Text = "Exception Occured";
            lblStackTrace.Text = ex.StackTrace;
        }
    }
}
