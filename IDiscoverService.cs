using fekon_repository_datamodel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fekon_repository_api
{
    public interface IDiscoverService
    {
        IQueryable<Author> DiscoverAuthor(string category, long subcategory, char? startChar);
        IQueryable<DateTime> DiscoverPublishDt(string category, long subcategory, DateTime dateFrom, DateTime dateTo);
        IQueryable<Repository> GeneralSearch(string query, string category = "", long subcategory = 0);
    }
}
