using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameworkControls.Controls
{
    public partial class CustomButton : Button
    {
        public CustomButton()
        {
            InitializeComponent();
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackColor = Color.FromArgb(46, 204, 113);
            this.ForeColor = Color.White;
            this.FlatAppearance.MouseOverBackColor = Color.FromArgb(38,166,91);
            this.FlatAppearance.BorderSize = 0;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
