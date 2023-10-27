using AutoMapper;
using NewsApp.Alerts;
using NewsApp.Searchs;
using NewsApp.Failures;
using NewsApp.Reads;
using NewsApp.Notifications;
using NewsApp.Alerts.AlertsSearches;
using NewsApp.Alerts.AlertsThemes;
using NewsApp.Articles;
using NewsApp.Themes;
using NewsApp.ArticlesOrThemes.Themes;
using NewsApp.ArticlesOrThemes.Articles;
using NewsApp.Notifications.NotificationsApp;
using NewsApp.Notifications.NotificationsMail;

namespace NewsApp;

public class NewsAppApplicationAutoMapperProfile : Profile
{
    public NewsAppApplicationAutoMapperProfile()
    {
        //CreateMap<ArticleOrTheme, ArticleOrThemeDto>();
        //CreateMap<CreateUpdateArticleOrThemeDto, ArticleOrTheme>();

        //CreateMap<Alert, AlertDto>();
        //CreateMap<CreateUpdateAlertDto, Alert>();

        CreateMap<AlertSearch, AlertSearchDto>();
        CreateMap<CreateUpdateAlertSearchDto, AlertSearch>();

        CreateMap<AlertSearch, AlertThemeDto>();
        CreateMap<CreateUpdateAlertThemeDto, AlertSearch>();

        CreateMap<Theme, ThemeDto>();
        CreateMap<CreateUpdateThemeDto, Theme>();

        CreateMap<Failure, FailureDto>();
        CreateMap<CreateUpdateFailureDto, Failure>();

        CreateMap<Article, ArticleDto>();
        CreateMap <CreateUpdateArticleDto, ArticleDto>();

        CreateMap<Read, ReadDto>();
        CreateMap<CreateUpdateReadDto, Read>();

        CreateMap<Notification, ReadDto>();


        CreateMap<NotificationMail, NotificationAppDto>();
        CreateMap<CreateUpdateNotificationAppDto, NotificationMail>();

        CreateMap<NotificationMail, NotificationMailDto>();
        CreateMap<CreateUpdateNotificationMailDto, NotificationMail>();

        CreateMap<Search, SearchDto>();
        CreateMap<Searchs.CreateUpdateSearchDto, Search>();

        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */


    }
}
