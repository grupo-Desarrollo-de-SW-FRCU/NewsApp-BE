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
using NewsApp.ArticlesOrThemes.Articles;
using NewsApp.ArticlesOrThemes;
using NewsApp.Themes;
using NewsApp.ArticlesOrThemes.Themes;

namespace NewsApp;

public class NewsAppApplicationAutoMapperProfile : Profile
{
    public NewsAppApplicationAutoMapperProfile()
    {
        CreateMap<ArticleOrTheme, ArticleOrThemeDto>();
        CreateMap<CreateUpdateArticleOrThemeDto, ArticleOrTheme>();

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

        CreateMap<Alert, AlertDto>();
        CreateMap<CreateUpdateAlertDto, Alert>();

        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */


    }
}
