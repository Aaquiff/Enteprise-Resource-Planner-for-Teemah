using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using System.Windows.Forms;



namespace FinishedGoodManagement
{
    class SucessError
    {
         public static class PanMessage
    {
        public static void Show(IWin32Window owner,string message)
        {
            MetroMessageBox.Show(owner,message,"Success",MessageBoxButtons.OK,MessageBoxIcon.Question);
        }
        public static void Show(IWin32Window owner, string title, string message)
        {
            MetroMessageBox.Show(owner, message, title, MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }

    }
}
