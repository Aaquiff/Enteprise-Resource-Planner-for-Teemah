using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductProcessManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Products.addEditProduct());
            //Application.Run(new Products.addEditProduct(11));
            //Application.Run(new Products.viewProducts());
            //Application.Run(new Products.viewProduct());
            //Application.Run(new Products.selectRawMaterial());
            //Application.Run(new WorkOrders.addWorkOrder());
            //Application.Run(new workOrders());
            //Application.Run(new workOrder());
            //Application.Run(new Remarks.remark());
            //Application.Run(new remarks());
            Application.Run(new productRequets());
        }
    }
}
