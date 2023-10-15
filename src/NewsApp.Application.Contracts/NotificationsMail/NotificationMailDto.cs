using System;
using System.Collections.Generic;
using System.Text;
using Abp.Authorization.Users;
using Volo.Abp.Application.Dtos;

namespace NewsApp.NotificationsMail
{
    public class NotificationMailDto : EntityDto<Guid>
    {
        // el DTO debería tener estos atributos también, pero no se puede porque no es de la clase
        //public required string Title { get; set; }
        //public DateTime DateTime { get; set; }
        public string Message { get; set; }
        public AbpUserBase User { get; set; }
    }
}
