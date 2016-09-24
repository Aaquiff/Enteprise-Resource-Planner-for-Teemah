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
            //panel1.Visible = false;
            //menuStrip1.Visible = false;
            //Application.Run(new Products.addEditProduct());
            //Application.Run(new Products.addEditProduct(11));
            //Application.Run(new Products.viewProducts());
            //Application.Run(new Products.viewProduct());
            //Application.Run(new Products.selectRawMaterial());

            //Application.Run(new productRequets());
            //Application.Run(new WorkOrders.addWorkOrder());

            //Application.Run(new workOrders());
            //Application.Run(new workOrder());
            //Application.Run(new Remarks.remark());
            
            Application.Run(new remarks());
            //Application.Run(new productRequets());


            //Application.Run(new Dashboard());
            //Application.Run(new Reports.Work_Orders_vs_Time());

            //Application.Run(new Reports.Products_vs_Time());

            //Application.Run(new Reports.Work_Orders_vs_Time_Taken());

            //Application.Run(new Reports.Products_vs_Time_Taken());

            //Application.Run(new Reports.Remark_Report());
        }
    }
}
