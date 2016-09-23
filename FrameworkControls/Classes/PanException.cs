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
        public static void Show(IWin32Window owner,MySqlException ex)
        {
            MetroMessageBox.Show(owner, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void Show(IWin32Window owner, string title, string message)
        {
            MetroMessageBox.Show(owner, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
