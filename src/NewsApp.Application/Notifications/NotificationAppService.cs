using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace NewsApp.Notifications
{
    public class NotificationAppService : NewsAppAppService, INotificationAppService
    {
        private readonly IRepository<Notification, int> _notificationRepository;
        private readonly UserManager<Volo.Abp.Identity.IdentityUser> _userManager;


        public NotificationAppService(IRepository<Notification, int> notificationRepository, UserManager<Volo.Abp.Identity.IdentityUser> userManager, IRepository<Theme, int> themeRepository)
        {
            _notificationRepository = notificationRepository;
            _userManager = userManager;
        }

        public async Task<NotificationDto> CreateNotificationAsync(CreateUpdateNotificationDto input, string searchString)
        {
            var userGuid = CurrentUser.Id.GetValueOrDefault();

            input.Title = $"Se han encontrado nuevos resultados para la búsqueda '{searchString}'";

            var identityUser = await _userManager.FindByIdAsync(userGuid.ToString());

            var notification = ObjectMapper.Map<CreateUpdateNotificationDto, Notification>(input);

            notification = await _notificationRepository.InsertAsync(notification, autoSave: true);
       
            return ObjectMapper.Map<Notification, NotificationDto>(notification);
        }
    }
}
