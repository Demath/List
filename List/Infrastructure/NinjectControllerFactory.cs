using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using List.Models.Abstract;
using List.Models.Concrete;

namespace List.Infrastructure {
    public class NinjectControllerFactory : DefaultControllerFactory {
        private IKernel ninjectKernel;
        public NinjectControllerFactory() {
            ninjectKernel = new StandardKernel();
            addBindings();
        }
        protected override IController GetControllerInstance(
            RequestContext requestContext, Type controllerType) {
            return controllerType == null ?
                                     null :
                    (IController)ninjectKernel.Get(controllerType);
        }
        private void addBindings() {
            ninjectKernel.Bind<IInputInfoRepository>().To<ConcInpInfoRepository>();
        }
    }
}