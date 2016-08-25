using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinishedGoodManagement
{
    class FormPopoup
    {
        internal void Show(Form1 form1)
        {
            var Email = new FormPopoup();
            Email.Show(this);
        }
    }
}
