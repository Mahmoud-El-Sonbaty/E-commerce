using AutoMapper;
using MenStore.DTO.Category;
using MenStore.DTO.OrderDetail;
using MenStore.DTO.OrderMaster;
using MenStore.DTO.Product;
using MenStore.DTO.User;
using MenStore.Models;
namespace MenStore.Application.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<GetOneOrderMasterDTO, OrderMaster>().ReverseMap();
            CreateMap<GetAllOrderMasterDTO, OrderMaster>().ReverseMap();
            CreateMap<GetOneOrderDetailDTO, OrderDetail>().ReverseMap();
            CreateMap<GetAllOrderDetailDTO, OrderDetail>().ReverseMap();
            //CreateMap<GetOneBookAuthorDTO, BookAuthor>().ReverseMap()
            //    .ForMember(dest => dest.BookTitle, opt => opt.MapFrom(src => src.Book.Title))
            //    .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Author.Name));
            //CreateMap<GetAllBookAuthorDTO, BookAuthor>().ReverseMap()
            //    .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Author.Name))
            //    .ForMember(dest => dest.BookTitle, opt => opt.MapFrom(src => src.Book.Title));
            //Added By Hossam
            CreateMap<CreateCategoryDTO, Category>().ReverseMap();
            CreateMap<GetCategoryDTO, Category>().ReverseMap();
            //Added By Walid
            CreateMap<CreateAdminUserDTO, User>().ReverseMap();
            CreateMap<CreateUserDTO, User>().ReverseMap();
            CreateMap<GetOneAdminUserDTO, User>().ReverseMap();
            CreateMap<GetOneUserDTO, User>().ReverseMap();
            CreateMap<GetAllAdminUserDTO, User>().ReverseMap();
            CreateMap<GetAllUserDTO, User>().ReverseMap();
            //Added By ElGhoul
            CreateMap<CreateProductDTO, Product>().ReverseMap();
            CreateMap<GetAllProductDTO, Product>().ReverseMap()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));    
            CreateMap<GetAllProductUserDTO, Product>().ReverseMap()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));
            CreateMap<GetOneProductDTO, Product>().ReverseMap()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));

        }
    }
}
