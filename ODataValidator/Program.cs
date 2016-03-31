using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODataValidator
{
    using System.Windows.Forms;

    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Provide commandline interface - 3/31/2016, Shawn South

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ODataValidator());
        }
    }
}
