using System;
using NewsApp.Searchs;
using Volo.Abp.Application.Dtos;

namespace NewsApp.Failures;

public class FailureDto : EntityDto<Guid>
{
    public String Name { get; set; }
    public String Description { get; set; }
    public String ErrorCode { get; set; }
    public DateTime ErrorDateTime { get; set; }
    public Exception Exception { get; set; }
    public SearchDto Search { get; set; }
    public Guid SearchOfFailureId { get; set; } // va en el Dto al ser un id?
}