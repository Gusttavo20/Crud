using Crud.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using Crud.Infra;

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
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            NinjectRepos.ComponenteModulo(ModuloAplicacao.Create());
            Application.Run(NinjectRepos.Resolver<FomsListaCadastrados>());
        }
    }
}
