using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkControls.API
{
    public static class ErrorSys
    {
        public static void ShowError(Exception ex)
        {
            FrameworkControls.Dialogs.FrameworkMessageBox box = new FrameworkControls.Dialogs.FrameworkMessageBox(ex.Message);
            box.ShowDialog();
        }
    }
}
