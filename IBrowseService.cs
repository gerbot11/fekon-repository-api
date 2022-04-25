using fekon_repository_datamodel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fekon_repository_api
{
    public interface IBrowseService
    {
        IQueryable<Repository> AuthorBrowseResult(long authorId, string query, string category = "", long subcategory = 0);
        Task<IEnumerable<Repository>> BrowseReposByCategoryAsync(string category, long subcategory);
        IQueryable<Repository> KeywordRepoResult(string keywordcode);
        IQueryable<Repository> PublishDtBrowseResult(DateTime publishDt, string cat, long subcat);
        IQueryable<Repository> YearRangeBrowseResult(string yrange);
    }
}
