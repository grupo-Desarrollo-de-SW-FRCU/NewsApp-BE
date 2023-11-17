﻿using Microsoft.Extensions.DependencyInjection;
using NewsApp.EntityFrameworkCore;
using NewsApp.KeyWords;
using NewsApp.News;
using NewsApp.Themes;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.BackgroundWorkers;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace NewsApp;

[DependsOn(
    typeof(NewsAppDomainModule),
    typeof(AbpAccountApplicationModule),
    typeof(NewsAppApplicationContractsModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule),
    typeof(AbpBackgroundWorkersModule)
    )]
public class NewsAppApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<NewsAppApplicationModule>();
        });

        context.Services.AddTransient<IRepository<Theme, Guid>, EfCoreRepository<NewsAppDbContext, Theme, Guid>>();
        context.Services.AddTransient<INewsService, NewsApiService>();
        context.Services.AddTransient<IRepository<KeyWord, Guid>, EfCoreRepository<NewsAppDbContext, KeyWord, Guid>>();

    }

        public override async Task OnApplicationInitializationAsync( //ABPMODULE NO TIENE INITIALIZEASYNC
            ApplicationInitializationContext context)
        {
         //modificadores de inicializacion 
            await context.AddBackgroundWorkerAsync<BuscadorBackground>(); //El worker deberia estar siempre corriendo o cuando la app este en uso?
        }
    

}
