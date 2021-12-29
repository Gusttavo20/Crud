using Crud.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using Crud.Infra;
using DataModel;
using LinqToDB.Data;

namespace Crud
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataConnection.DefaultSettings = new MySettings();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            NinjectRepos.ComponenteModulo(ModuloAplicacao.Create());
            Application.Run(NinjectRepos.Resolve<FomsListaCadastrados>());
                      
            
        }
    }
}
