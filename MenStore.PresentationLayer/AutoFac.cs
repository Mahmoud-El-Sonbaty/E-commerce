using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using AutoMapper;
using MenStore.Application.Contracts;
using MenStore.Application.Mapper;
using MenStore.Application.Services;
using MenStore.Application.Services.CategoryServices;
using MenStore.Application.Services.ProductServices;
using MenStore.Context;
using MenStore.Infrastructure;

namespace MenStore.PresentationLayer
{
    public class AutoFac
    {
        public static Autofac.IContainer Inject()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<CategoryServices>().As<ICategorySevice>();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();
            builder.RegisterType<StoreContext>().As<StoreContext>();
            builder.Register(c => new MapperConfiguration(a =>
            {
                a.AddProfile<AutoMapperProfile>();

            }));

            builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve))
                .As<IMapper>()
                .InstancePerLifetimeScope();
            return builder.Build();
        }
    }
}
