using System;
using NewsApp.Searchs;
using Volo.Abp.Application.Dtos;

namespace NewsApp.Failures;

public class FailureDto : EntityDto<Guid>
{
    public DateTime ErrorDateTime { get; set; }
    public Exception Exception { get; set; }
    public SearchDto Search { get; set; }
    public Guid SearchOfFailureId { get; set; }
}