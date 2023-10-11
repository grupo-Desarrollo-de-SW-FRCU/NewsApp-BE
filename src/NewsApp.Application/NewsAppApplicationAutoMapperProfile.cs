using AutoMapper;
using NewsApp.Alertas;
using NewsApp.Busquedas;

namespace NewsApp;

public class NewsAppApplicationAutoMapperProfile : Profile
{
    public NewsAppApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Busqueda, BusquedaDto>();
        CreateMap<Alerta, AlertaDto>();

    }
}
