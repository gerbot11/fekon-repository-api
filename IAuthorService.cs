using fekon_repository_datamodel.MergeModels;
using fekon_repository_datamodel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fekon_repository_api
{
    public interface IAuthorService
    {
        Task<string> AddNewAuthorAsync(Author author);
        Task<string> DeleteAuthorAsync(long id);
        Task<string> EditAuthorAsync(Author author);
        IQueryable<Author> GetAdvisiorForSelectionByName(string name);
        Task<Author> GetAuthorByAuthorIdAsync(long id);
        IQueryable<Author> GetAuthorForSelectionByName(string name);
        List<string> GetAuthorNameByRepositoryId(long repoid);
        Task<IEnumerable<Author>> GetAuthorsAdvisorAsync();
        IQueryable<Author> GetAuthorsForIndexDash(string query, string isadv);
        Task<IEnumerable<MergeAuthorGrouping>> GetListAdvisiorForSideMenu();
        IEnumerable<Author> GetListAuthorByReposId(long repoid);
        Task<IEnumerable<Author>> GetListAuthorForAddRepos();
        Task<IEnumerable<MergeAuthorGrouping>> GetListAuthorForSideMenu();
    }
}
