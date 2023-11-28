using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace NewsApp.APIStatistics;
public interface IAPIStatisticAppService : IApplicationService
{
    Task<double> GetAverageAPIAccessTimeAsync();
    Task<APIStatisticDto> GetAPIStatisticsAsync();
}

