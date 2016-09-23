using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FrameworkControls.Classes
{
    public static class PanException
    {
        public static void Show(IWin32Window owner,Exception ex)
        {
            MetroMessageBox.Show(owner, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Show(IWin32Window owner, string header,string message)
        {
            MetroMessageBox.Show(owner, message, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void metroGrid1_DataError(IWin32Window owner, Object sender ,DataGridViewDataErrorEventArgs e)
        {
            MetroMessageBox.Show(owner, e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
