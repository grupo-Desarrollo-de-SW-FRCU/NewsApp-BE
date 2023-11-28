using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using NewsApp.News;
using NewsApp.Notifications;
using NewsApp.Searches;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.AlertsSearches
{
    public class AlertSearchAppService : NewsAppAppService, IAlertSearchAppService
    {
        private readonly IRepository<Search, int> _searchRepository;
        private readonly IRepository<AlertSearch, int> _alertSearchRepository;
        private readonly UserManager<Volo.Abp.Identity.IdentityUser> _userManager;

        private readonly INewsAppService _newsAppService;
        private readonly INotificationAppService _notificationAppService;

        public AlertSearchAppService(
            IRepository<Search, int> searchRepository,
            IRepository<AlertSearch, int> alertSearchRepository,
            UserManager<Volo.Abp.Identity.IdentityUser> userManager,

            INewsAppService newsAppService,
            INotificationAppService notificationAppService

            )
        {
            _searchRepository = searchRepository;
            _alertSearchRepository = alertSearchRepository;
            _userManager = userManager;

            _newsAppService = newsAppService;
            _notificationAppService = notificationAppService;
        }

        public async Task<AlertSearchDto> CreateAlertAsync(int searchId)
        {
            AlertSearch alert = null;

            var userGuid = CurrentUser.Id.GetValueOrDefault();

            var identityUser = await _userManager.FindByIdAsync(userGuid.ToString());

            var search = await _searchRepository.FindAsync(searchId);

            alert = new AlertSearch
            {
                Search = search,
                AlertOfSearchId = searchId,
                CreatedDate = DateTime.Now,
                User = identityUser
            };

            alert = await _alertSearchRepository.InsertAsync(alert, autoSave: true);

            return ObjectMapper.Map<AlertSearch, AlertSearchDto>(alert);
        }

        public async Task<ICollection<NotificationDto>> NotifyUserOfNewResultsAsync()
        {

            var userGuid = CurrentUser.Id.GetValueOrDefault();

            var identityUser = await _userManager.FindByIdAsync(userGuid.ToString());

            var alerts = await _alertSearchRepository.GetListAsync(a => a.User == identityUser);

            if (alerts.Count > 0)
            {
                var listNotifications = new List<NotificationDto>();

                foreach (var alert in alerts)
                {
                    var search = await _searchRepository.FindAsync(s => s.AlertSearch.Id == alert.Id);
                    var searchString = search.SearchString;
                    if (searchString != null) {
                        var news = await _newsAppService.Search(searchString);

                        if (news.Count > 0)
                        {
                            var newNotification = new CreateUpdateNotificationDto
                            {
                                Title = alert.Search.SearchString,
                                DateTime = DateTime.Now,
                                AlertId = alert.Id
                            };
                            var notification = await _notificationAppService.CreateNotificationAsync(newNotification);

                            listNotifications.Add(notification);
                        }
                    }
                }
                return listNotifications;
            }
            else { throw new Exception("No se han encontrado alertas para el usuario"); }

        }
    }
}