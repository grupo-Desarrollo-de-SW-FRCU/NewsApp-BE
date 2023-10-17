using System;
using Volo.Abp.Application.Dtos;

namespace NewsApp.Failures;

public class FailureDto : EntityDto<Guid>
{
    public String Name { get; set; }
    public String Description { get; set; }
    public String ErrorCode { get; set; }
    public DateTime ErrorDateTime { get; set; }
    public Exception Exception { get; set; }
}