using fekon_repository_datamodel.MergeModels;
using fekon_repository_datamodel.Models;
using System;
using System.Linq;

namespace fekon_repository_api
{
    public interface IDiscoverService
    {
        IQueryable<MergeAuthorGrouping> DiscoverAuthor(string query, string category, long subcategory, char? startChar);
        IQueryable<KeywordsGrouping> DiscoverKeyword(string keywordcode);
        IQueryable<MergeAuthorGrouping> DiscoverMoreAuthor(string query, string isAdvisior, char? startChar);
        IQueryable<DateTime> DiscoverPublishDt(string category, long subcategory, DateTime dateFrom, DateTime dateTo);
        IQueryable<Repository> GeneralSearch(string query, string category = "", long subcategory = 0);
    }
}
