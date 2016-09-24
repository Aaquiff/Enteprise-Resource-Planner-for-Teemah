using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FinishedGoodManagement
{
    class ErrorError
    {
        public static class PanException
        {
            public static void Show(IWin32Window owner, string message)
            {
                MetroMessageBox.Show(owner, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
