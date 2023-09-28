using System;
using System.Collections.Generic;
using NewsApp.Errors;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace NewsApp.Accesses;

public class Access : Entity<Guid>
{
    public DateTime FechayHoraIngreso { get; set; }

    public DateTime FechayHoraEgreso { get; set; }

    public ICollection<Error>? Errors { get; set; } //Sub collection
}

