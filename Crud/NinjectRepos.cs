using Crud.Domain;
using Crud.Infra;
using System;
using System.Collections.Generic;
using System.Text;
using Ninject;
using Ninject.Modules;
using DataModel;
using LinqToDB;
using Ninject.Parameters;

namespace Crud.UI
{
    
    static class NinjectRepos 
    {
        private static IKernel _ninjectKernel;
        public static void ComponenteModulo(INinjectModule module)
        {
            _ninjectKernel = new StandardKernel(module);
        }
        public static T Resolve<T>(params IParameter[] parameters)
        {
            return _ninjectKernel.Get<T>(parameters);
        }
    }

    public class ModuloAplicacao : NinjectModule
    {
        public override void Load()
        {
            //Bind<IRepositorioListaCliente>().To<RepositorioListaCliente>();
            Bind<IRepositorioListaCliente>().To<RepositorioBancoDados>();
        }
        public static ModuloAplicacao Create()
        {
            return new ModuloAplicacao();
        }
    }
}

