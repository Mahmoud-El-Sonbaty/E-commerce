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
using MenStore.Application.Services.ProductServices;
using MenStore.Application.Services.CategoryServices;
using MenStore.Application.Services.OrderMasterServices;
using MenStore.Application.Services.OrderDetailServices;
using MenStore.Application.Services.UserServices;
using MenStore.Context;
using MenStore.Infrastructure;

namespace MenStore.PresentationLayer
{
    public class AutoFac
    {
        public static Autofac.IContainer Inject()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<OrderMasterService>().As<IOrderMasterService>();
            builder.RegisterType<OrderMasterRepository>().As<IOrderMasterRepository>();
            builder.RegisterType<OrderDetailService>().As<IOrderDetailService>();
            builder.RegisterType<OrderDetailRepository>().As<IOrderDetailRepository>();
            builder.RegisterType<CategoryService>().As<ICategoryService>();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<UserService>().As<IUserService>();
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
