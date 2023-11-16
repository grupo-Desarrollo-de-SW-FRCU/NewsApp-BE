using AutoMapper;
using NewsApp.Alerts;
using NewsApp.Searches;
using NewsApp.Failures;
using NewsApp.Reads;
using NewsApp.Notifications;
using NewsApp.Alerts.AlertsSearches;
using NewsApp.Alerts.AlertsThemes;
using NewsApp.Articles;
using NewsApp.Themes;

using NewsApp.Notifications.NotificationsApp;
using NewsApp.Notifications.NotificationsMail;
using NewsApp.News;
using NewsApp.KeyWords;

namespace NewsApp;

public class NewsAppApplicationAutoMapperProfile : Profile
{
    public NewsAppApplicationAutoMapperProfile()
    {


        //CreateMap<Alert, AlertDto>();
        //CreateMap<CreateUpdateAlertDto, Alert>();

        CreateMap<KeyWord, KeyWordDto>().ReverseMap();

        CreateMap<NewsDto, ArticleDto>().ReverseMap();

        CreateMap<AlertSearch, AlertSearchDto>().ReverseMap();
        CreateMap<CreateUpdateAlertSearchDto, AlertSearch>();

        CreateMap<AlertTheme, AlertThemeDto>().ReverseMap();
        CreateMap<CreateUpdateAlertThemeDto, AlertTheme>();

        CreateMap<ThemeDto, Theme>().ReverseMap();
        CreateMap<CreateUpdateThemeDto, Theme>();

        CreateMap<Failure, FailureDto>().ReverseMap();
        CreateMap<CreateUpdateFailureDto, Failure>();

        // CreateMap<Article, ArticleDto>();
        CreateMap<ArticleDto, Article>().ReverseMap();
        CreateMap<CreateUpdateArticleDto, ArticleDto>();

        CreateMap<Read, ReadDto>().ReverseMap();
        CreateMap<CreateUpdateReadDto, Read>();

        CreateMap<Notification, ReadDto>().ReverseMap();


        CreateMap<NotificationMail, NotificationAppDto>().ReverseMap();
        CreateMap<CreateUpdateNotificationAppDto, NotificationMail>();

        CreateMap<NotificationMail, NotificationMailDto>().ReverseMap();
        CreateMap<CreateUpdateNotificationMailDto, NotificationMail>();

        CreateMap<Search, SearchDto>().ReverseMap();
        CreateMap<CreateUpdateSearchDto, Search>();

        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */


    }
}
