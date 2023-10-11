using System;
using Volo.Abp.Application.Dtos;

namespace NewsApp.Errors;

public class ErrorDto : EntityDto<Guid>
{
    public String Name { get; set; }
    public String Description { get; set; }
    public String ErrorCode { get; set; }
    public String Time { get; set; }
    public Exception ExceptionName { get; set; }
}