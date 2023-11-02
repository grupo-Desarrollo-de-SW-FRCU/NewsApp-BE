using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;
using Volo.Abp.Users;
using static Volo.Abp.Identity.Settings.IdentitySettingNames;

namespace NewsApp.Alerts
{
    public class AlertAppService : CrudAppService<Alert, AlertDto, Guid>, IAlertAppService
    {
        private readonly IRepository<IdentityUser, Guid> _userRepository;
        public AlertAppService(IRepository<Alert, Guid> repository, IRepository<IdentityUser, Guid> userRepository)
            : base(repository)
        {
            _userRepository = userRepository;
        }

        // falta definir Searches en user

        //public async Task CheckAlerts(Guid userId)
        //{
        //    var user = await _userRepository.GetAsync(userId);
        //    foreach (var search in user.Searches)
        //    {
        //        if (search.Alert != null)
        //        {
        //            var results = await ExecuteSearch(search.SearchString);
        //            if (results.Any())
        //            {
        //                await _notificationService.NotifyUser(userId);
        //                await DeleteAlert(search.Alert.Id);
        //            }
        //        }
        //    }
        //}
    }
}
