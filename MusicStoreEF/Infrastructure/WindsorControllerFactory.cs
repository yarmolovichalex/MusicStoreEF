﻿using Castle.MicroKernel;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MusicStoreEF.Infrastructure
{
    public class WindsorControllerFactory : DefaultControllerFactory
    {
        private readonly IKernel _kernel;

        public WindsorControllerFactory(IKernel kernel)
        {
            this._kernel = kernel;
        }

        public override void ReleaseController(IController controller)
        {
            _kernel.ReleaseComponent(controller);
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType == null)
            {
                throw new HttpException(404,
                    $"The controller for path '{requestContext.HttpContext.Request.Path}' could not be found.");
            }
            return (IController)_kernel.Resolve(controllerType);
        }
    }
}