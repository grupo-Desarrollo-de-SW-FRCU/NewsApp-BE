using System;
using Volo.Abp.Application.Dtos;

namespace NewsApp.Accesses;

public class AccessDto : EntityDto<Guid>
{
    public DateTime fechayHoraIngreso { get; set; }
    public DateTime fechayHoraEgreso { get; set; }

}