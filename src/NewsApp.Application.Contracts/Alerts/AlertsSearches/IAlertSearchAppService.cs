using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NewsApp.Searches;

namespace NewsApp.Alerts.AlertsSearches
{
    public interface IAlertSearchAppService : IAlertAppService
    {
        Task<AlertSearchDto> CreateAlertAsync(SearchDto inputSearch);
    }
}
