using Moq;
using ShoppingCart.Core.Domain;
using ShoppingCart.Core.Facade;
using System.Collections.Generic;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace ShoppingCart.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            var mockProducts = new Mock<IPoductRepository>();
            mockProducts.Setup(m => m.FindAll()).Returns(
                new List<Product>
                {
                    new Product{ ProductId =1,Name="Café", PhotoFile="Cafe.png",UnitPrice=1.5M},
                    new Product{ ProductId =1,Name="Thé", PhotoFile="tea.jpg",UnitPrice=1.5M},
                    new Product{ ProductId =1,Name="Chocolat", PhotoFile="chokolat.jpg",UnitPrice=1.5M},
                    new Product{ ProductId =1,Name="Gateaux", PhotoFile="gateau.jpg",UnitPrice=1.5M},
                }

                );
            container.RegisterInstance<IPoductRepository>(mockProducts.Object);
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}