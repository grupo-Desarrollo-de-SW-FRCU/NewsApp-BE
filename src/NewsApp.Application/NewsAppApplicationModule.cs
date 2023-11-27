﻿using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using NewsApp.BackgroundServices;
using NewsApp.EntityFrameworkCore;
using NewsApp.KeyWords;
using NewsApp.News;
using NewsApp.Themes;
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
    typeof(AbpBackgroundWorkersModule),
    typeof(NewsAppDomainModule),
    typeof(AbpAccountApplicationModule),
    typeof(NewsAppApplicationContractsModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule)
    )]
public class NewsAppApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<NewsAppApplicationModule>();
        });

        // context.Services.AddTransient<IRepository<Theme, int>, EfCoreRepository<NewsAppDbContext, Theme, int>>();
        context.Services.AddTransient<INewsService, NewsApiService>();
        // context.Services.AddTransient<IRepository<KeyWord, int>, EfCoreRepository<NewsAppDbContext, KeyWord, int>>();
    }

    public override async Task OnApplicationInitializationAsync(
            ApplicationInitializationContext context)
    {
        await context.AddBackgroundWorkerAsync<AlertChecker>();
    }
}
