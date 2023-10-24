using AutoMapper;
using NewsApp.Alerts;
using NewsApp.Searchs;
using NewsApp.Failures;
using NewsApp.Reads;
using NewsApp.Notifications;
using NewsApp.NotificationsApp;
using NewsApp.NotificationsMail;
using NewsApp.Sources;
using NewsApp.Alerts.AlertsSearches;
using NewsApp.Alerts.AlertsThemes;
using NewsApp.Articles;
using NewsApp.Themes;
using NewsApp.ArticlesOrThemes.Themes;
using NewsApp.ArticlesOrThemes.Articles;

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

        CreateMap<AlertTheme, AlertThemeDto>();
        CreateMap<CreateUpdateAlertThemeDto, AlertTheme>();

        CreateMap<Theme, ThemeDto>();
        CreateMap<CreateUpdateThemeDto, Theme>();

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

        CreateMap<Search, SearchDto>();
        CreateMap<CreateUpdateSearchDto, Search>();

        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */


    }
}
