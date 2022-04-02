using fekon_repository_datamodel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fekon_repository_api
{
    public interface IBrowseService
    {
        IQueryable<Repository> AuthorBrowseResult(long authorId, string category = "", long subcategory = 0);
        Task<IEnumerable<Repository>> BrowseReposByCategoryAsync(string category, long subcategory);
        IQueryable<Repository> PublishDtBrowseResult(DateTime publishDt);
        IQueryable<Repository> YearRangeBrowseResult(string yrange);
    }
}
