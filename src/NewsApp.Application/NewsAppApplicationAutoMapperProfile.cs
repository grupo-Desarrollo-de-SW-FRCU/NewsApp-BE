using NewsApp.Accesses;
using AutoMapper;
using NewsApp.Errors;
using NewsApp.Articles;
using NewsApp.Reads;

namespace NewsApp;

public class NewsAppApplicationAutoMapperProfile : Profile
{
    public NewsAppApplicationAutoMapperProfile()
    {
       

        CreateMap<Error, ErrorDto>();
        CreateMap<CreateUpdateErrorDto, Error>();

        CreateMap<Article, ArticleDto>();
        CreateMap <CreateUpdateArticleDto, ArticleDto>();

        CreateMap<Read, ReadDto>();
        CreateMap<CreateUpdateReadDto, Read>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
