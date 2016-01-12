using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using log4net.Config; 

namespace ProcessManager
{
    static class Program
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(Program));   
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            log4net.Config.DOMConfigurator.Configure();     
            Application.Run(new FormMain());
        }
    }
}
