using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;
using Moq;
using Ninject;
using SportSolution.Domain.Abstract;
using SportSolution.Domain.Concrete;
using SportSolution.Domain.Entities;

namespace SportSolution.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            //var mock = new Mock<IProductsRepository>();
            //mock.Setup(m => m.Products).Returns(new List<Product>
            //{
            //    new Product {Name="Bola de futebol", Price=80 },
            //    new Product {Name="Whey Protein", Price=120 },
            //    new Product {Name="Luva", Price=5 }
            //}.AsQueryable());
            ninjectKernel.Bind<IProductsRepository>().To<SportSolutionProductRepository>();
        }
    }
}
