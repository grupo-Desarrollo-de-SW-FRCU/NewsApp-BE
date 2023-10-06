using System;
using Volo.Abp.Application.Dtos;

namespace NewsApp.Errors;

public class ErrorDto : EntityDto<Guid>
{
    public string name { get; set; }
    public string errorCode { get; set; }
    public string description { get; set; }
}