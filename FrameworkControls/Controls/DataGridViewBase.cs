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
    public partial class DataGridViewBase : DataGridView
    {
        public DataGridViewBase()
        {
            InitializeComponent();
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.RowHeadersVisible = false;
            this.EnableHeadersVisualStyles = false;
        }

        /*protected override void OnColumnAdded(DataGridViewColumnEventArgs e)
        {
            base.OnColumnAdded(e);
            e.Column.HeaderText = e.Column.HeaderText.ToUpper().Replace("_"," ");
            
        }*/
    }
}
