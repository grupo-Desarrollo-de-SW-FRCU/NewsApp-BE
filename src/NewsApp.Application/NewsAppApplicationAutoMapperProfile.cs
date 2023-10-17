using AutoMapper;
using NewsApp.Alerts;
using NewsApp.Searchs;
using NewsApp.Failures;
using NewsApp.Articles;
using NewsApp.Reads;
using NewsApp.Notifications;
using NewsApp.NotificationsApp;
using NewsApp.NotificationsMail;
using NewsApp.Sources;

namespace NewsApp;

public class NewsAppApplicationAutoMapperProfile : Profile
{
    public NewsAppApplicationAutoMapperProfile()
    {
       

        CreateMap<Failure, FailureDto>();
        CreateMap<CreateUpdateFailureDto, Failure>();

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
        CreateMap<Search, SearchDto>();

        CreateMap<Search, SourceDto>(); //sirve para decir como transfomrar una clase de dominio en una dto

    }
}
