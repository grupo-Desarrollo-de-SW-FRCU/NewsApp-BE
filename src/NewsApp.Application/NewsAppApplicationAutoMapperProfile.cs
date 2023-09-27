using NewsApp.Accesses;
using AutoMapper;
using NewsApp.Errors;

namespace NewsApp;

public class NewsAppApplicationAutoMapperProfile : Profile
{
    public NewsAppApplicationAutoMapperProfile()
    {
        CreateMap<Access, AccessDto>();
        CreateMap<CreateUpdateAccessDto, Access>();

        CreateMap<Error, ErrorDto>();
        CreateMap<CreateUpdateErrorDto, Error>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
