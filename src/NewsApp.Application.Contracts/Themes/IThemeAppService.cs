using System;
using Abp.Application.Services;

namespace NewsApp.Themes
{
    public interface IThemeAppService : 
        ICrudAppService< //Defines CRUD methods
        ThemeDto, //Used to show books
        Guid, //Primary key of the book entity
        CreateUpdateThemeDto> //Used to create/update a book
    {

    }
}
