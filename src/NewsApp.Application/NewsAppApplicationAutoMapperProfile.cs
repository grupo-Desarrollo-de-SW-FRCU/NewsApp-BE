using AutoMapper;
using NewsApp.Errors;
using NewsApp.Articles;
using NewsApp.Reads;
using NewsApp.Notifications;
using NewsApp.NotificationsApp;
using NewsApp.NotificationsMail;

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

        CreateMap<NotificationMail, NotificationAppDto>();
        CreateMap<CreateUpdateNotificationAppDto, NotificationMail>();

        CreateMap<NotificationMail, NotificationMailDto>();
        CreateMap<CreateUpdateNotificationMailDto, NotificationMail>();

        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
