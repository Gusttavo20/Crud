using Crud.Domain;
using Crud.Infra;
using System;
using System.Collections.Generic;
using System.Text;
using Ninject;
using Ninject.Modules;


namespace Crud.UI
{
    
    static class NinjectRepos 
    {
        private static IKernel _ninjectKernel;
        public static void ComponenteModulo(INinjectModule module)
        {
            _ninjectKernel = new StandardKernel(module);
        }
        public static T Resolver<T>()
        {
            return _ninjectKernel.Get<T>();
        }
    }

    public class ModuloAplicacao : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepositorioListaCliente>().To<RepositorioListaCliente>();
        }
        public static ModuloAplicacao Create()
        {
            return new ModuloAplicacao();
        }
    }
}

