using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameworkControls.Classes
{
    public static class PanException
    {
        public static void Show(IWin32Window owner,MySqlException ex)
        {
            MetroFramework.MetroMessageBox.Show(owner,ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
