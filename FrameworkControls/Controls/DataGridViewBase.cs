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

            this.BackgroundColor = Color.SlateGray;
            /*
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.DefaultCellStyle.SelectionBackColor = Color.MediumPurple;
            this.GridColor = SystemColors.Control;
            this.BackgroundColor = Color.White;
            this.RowTemplate.Height = 30;
            this.ColumnHeadersHeight = 40;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.EnableHeadersVisualStyles = false;*/
        }

        protected override void OnColumnAdded(DataGridViewColumnEventArgs e)
        {
            base.OnColumnAdded(e);
            e.Column.HeaderText = e.Column.HeaderText.ToUpper().Replace("_"," ");
            
        }
    }
}
