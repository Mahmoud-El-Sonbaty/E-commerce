using AutoMapper;
using MenStore.DTO.Category;
using MenStore.DTO.OrderDetail;
using MenStore.DTO.OrderMaster;
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
        }
    }
}
