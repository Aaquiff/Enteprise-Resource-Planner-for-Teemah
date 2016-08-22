using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameworkControls.Dialogs
{
    public partial class FrameworkMessageBox : Form
    {
        public FrameworkMessageBox(string message)
        {
            InitializeComponent();
            label1.Text = message;
        }
    }
}
