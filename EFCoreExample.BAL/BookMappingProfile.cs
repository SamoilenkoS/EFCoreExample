using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using AutoMapper.Configuration;
using EFCoreExample.BAL.Models;
using EFCoreExample.BAL.OutputModels;

namespace EFCoreExample.BAL
{
    public class BookMappingProfile : Profile
    {
        public BookMappingProfile()
        {
            CreateMap<Book, DbBook>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()))
                .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author))
                .ForMember(dest => dest.PagesCount, opt => opt.MapFrom(src => src.PagesCount))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title));

            CreateMap<DbBook, Book>()
                .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Author))
                .ForMember(dest => dest.PagesCount, opt => opt.MapFrom(src => src.PagesCount))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title));
        }
    }
}
