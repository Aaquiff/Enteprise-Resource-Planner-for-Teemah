using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explorer
{
    public partial class WebBrowser : Form
    {
        public WebBrowser()
        {
            InitializeComponent();
        }

        public WebBrowser(string url)
        {
            InitializeComponent();
            Uri ur = new Uri(url);
            webBrowser1.Url = ur;
        }
    }
}
