using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace NewsApp.Accesses;

public class Access : Entity<Guid>
{
    public DateTime fechayHoraIngreso { get; set; }

    public DateTime fechayHoraEgreso { get; set; }
}

