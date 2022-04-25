using fekon_repository_datamodel.MergeModels;
using fekon_repository_datamodel.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace fekon_repository_api
{
    public interface IRepoService
    {
        Task<string> CreateNewRepoAsync(Repository repository, List<RepoFile> files, List<long> authorIds, List<string> keywords);
        Task DeleteRepoAsync(long id);
        Task<string> EditRepoAsync(Repository repository, List<RepoFile> files, List<long> authorIds, string userEdit, List<string> keywords);
        Task<FileDetail> GetFileDetailForViewAsync(long id);
        Task<MergeRepoView> GetRepoByIdAsync(long id);
        Task<MergeRepoIndex> GetRepositoriesForIndexHomePageAsync();
        IQueryable<Repository> GetRepositoriesForIndexPageAsync(string query);
        Repository GetRepositoryByRepoId(long id);
        Dictionary<string, int> GetCountRepositoryOfRangeYear(List<string> year);
        IQueryable<Repository> MoreSearchResult(string title, long? type, long? colld, int? year, int? yearTo, string author);
        FileDetail GetFileDetailByFileName(string fname);
        void InsertDownloadStat(long fileid, string userid, bool issuccess, string errMsg = "");
        MergeRepoViewDashboard GetRepositoryForDetailById(long id);
        IQueryable<Repository> MoreSearchRepositoryDashboard(string title, string author, int? yearFrom, int? yearTo, long? type, long? colld);
        IQueryable<MergeRepositoryPaging> GetRepositoryPagings(string title, string author, int? year, long? type, long? colld);
        DataTable GetDataReportStatPeryear(int year);
        Task<Dictionary<int, int>> GetListYearPublishAsync();
        IEnumerable<CurrentFileInfo> GetCurrentFileInfos(long repoid);
        string DeleteRepositoryFile(long id);
        IEnumerable<KeywordsGrouping> GetGroupingKeywordForSideMenu();
        bool CheckRepoHasFilePerType(long repoid, long typeid);
    }
}
