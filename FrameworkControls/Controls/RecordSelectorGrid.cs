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
    public partial class RecordSelectorGrid : DataGridView
    {
        public RecordSelectorGrid()
        {
            InitializeComponent();
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.RowHeadersVisible = false;
            this.EnableHeadersVisualStyles = false;
            this.RowTemplate.Height = 30;
            this.GridColor = SystemColors.Control;
            this.MultiSelect = false;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.EditMode = DataGridViewEditMode.EditOnKeystroke;
            this.BackgroundColor = SystemColors.Window;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToResizeRows = false;
            this.ColumnHeadersHeight = 40;
            this.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.ColumnHeadersVisible = false;

            DataGridViewCellStyle defaultCellStyle = new DataGridViewCellStyle();
            defaultCellStyle.SelectionBackColor = Color.FromArgb(46, 204, 113);
            this.DefaultCellStyle = defaultCellStyle;

            DataGridViewCellStyle header = new DataGridViewCellStyle();
            header.SelectionBackColor = Color.DarkSlateGray;
            this.ColumnHeadersDefaultCellStyle = header;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
