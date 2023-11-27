using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NewsApp.AlertsSearches;
using NewsApp.News;
using NewsApp.Notifications;
using Umbraco.Core.Persistence.Repositories;
using Volo.Abp.BackgroundWorkers;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;
using Volo.Abp.Threading;
using Volo.Abp.Users;

namespace NewsApp.BackgroundServices
{
    public class AlertChecker : AsyncPeriodicBackgroundWorkerBase
    {
        public AlertChecker(
                AbpAsyncTimer timer,
                IServiceScopeFactory serviceScopeFactory) : base(
                timer,
                serviceScopeFactory)
        {
            Timer.Period = 1 * 60 * 1000 / 10; // en milisegundos
        }

        protected async override Task DoWorkAsync(
            PeriodicBackgroundWorkerContext workerContext)
        {
            Logger.LogInformation("Checking if there are new results for the alerts of the current user...");

            //Resolve dependencies
            var notificationAppService = workerContext.ServiceProvider.GetRequiredService<INotificationAppService>();

            var newsApiService = workerContext.ServiceProvider.GetRequiredService<INewsService>();

            var userRepository = workerContext.ServiceProvider.GetRequiredService<IUserRepository>();

            var currentUser = workerContext.ServiceProvider.GetRequiredService<ICurrentUser>();

            var alertRepository = workerContext.ServiceProvider.GetRequiredService<IRepository<AlertSearch, int>>();

            var alerts = await alertRepository.GetListAsync(a => a.User == currentUser);

            //Do the work
            foreach (var alert in alerts)
            {
                var news = await newsApiService.GetNewsAsync(alert.Search.SearchString);
                if (news.Count > 0)
                {
                    var notification = new CreateUpdateNotificationDto
                    {
                        Title = alert.Search.SearchString,
                        DateTime = DateTime.Now,
                        AlertId = alert.Id
                    };
                    await notificationAppService.CreateNotificationAsync(notification);
                }
            }

            Logger.LogInformation("AlertChecker has completed it's work...");
        }
    }

}
