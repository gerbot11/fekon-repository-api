using fekon_repository_datamodel.DashboardModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fekon_repository_api
{
    public interface IDashboardService
    {
        SummarySection SetDataSummary();
        Task<IEnumerable<TotalRepositoryPerColl>> SetTotalRepoPerCollection();
        Task<IEnumerable<TotalRepositoryPerType>> SetTotalRepoPerType();
        Task<IEnumerable<TotalRepositoryPerYearPublish>> SetTotalRepoPerYearPublish();
        IEnumerable<TotalRepositoryPerYearPublish> SetTotalRepoPerYearPublishWithSP(string connString);
    }
}
