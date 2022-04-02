using fekon_repository_datamodel.MergeModels;
using fekon_repository_datamodel.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fekon_repository_api
{
    public interface IRepoService
    {
        Task<string> CreateNewRepoAsync(Repository repository, List<IFormFile> files, List<long> authorIds, List<string> langCode);
        Task DeleteRepoAsync(long id);
        Task<string> EditRepoAsync(Repository repository, List<IFormFile> files, List<long> authorIds, List<string> langCode);
        Task<FileDetail> GetFileDetailForViewAsync(long id);
        Task<MergeRepoView> GetRepoByIdAsync(long id);
        Task<MergeRepoIndex> GetRepositoriesForIndexHomePageAsync();
        IQueryable<Repository> GetRepositoriesForIndexPageAsync(string query);
        Repository GetRepositoryByRepoId(long id);
        List<string> CheckFileStatus(IEnumerable<FileDetail> fileDetails);
        Dictionary<string, int> GetCountRepositoryOfRangeYear(List<string> year);
        IQueryable<Repository> MoreSearchResult(string title, long? type, long? colld, int? year, int? yearTo, string author);
        FileDetail GetFileDetailByFileName(string fname);
        void InsertDownloadStat(long fileid, string userid);
        MergeRepoViewDashboard GetRepositoryForDetailById(long id);
        IQueryable<Repository> MoreSearchRepositoryDashboard(string title, string author, int? yearFrom, int? yearTo, long? type, long? colld);
        IQueryable<MergeRepositoryPaging> GetRepositoryPagings(string title, string author, int? year, long? type, long? colld);
        DataTable GetDataReportStatPeryear(int year);
        Task<Dictionary<int, int>> GetListYearPublishAsync();
    }
}
