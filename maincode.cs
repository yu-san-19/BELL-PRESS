using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BELL_PRES
{
    public class maincode
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            main_form form = new main_form();
            Application.Run(form);
        }
    }
}
