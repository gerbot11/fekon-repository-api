using fekon_repository_datamodel.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fekon_repository_api
{
    public interface IGeneralService
    {
        bool CheckDuplicateCode(string code, long? id);
        RefKeyword CreateNewKeyword(string keyword);
        Task CreateNewRefRepositoryFileType(RefRepositoryFileType refRepositoryFileType);
        Task EditRefRepositoryFileType(RefRepositoryFileType refRepositoryFileType);
        RefKeyword GetRefKeywordObjByCode(string keycode);
        RefKeyword GetRefKeywordObjById(long id);
        IQueryable<RefKeyword> GetRefKeywords(string q);
        RefRepositoryFileType GetRefRepositoryFileTypeByCode(string code);
        Task<IEnumerable<RefRepositoryFileType>> GetRefRepositoryFileTypes();
        IQueryable<RefRepositoryFileType> GetRefRepositoryFileTypesPaging();
        Task<IEnumerable<RefKeyword>> GetRepositoryKeywordByRepoId(long repoid);
    }
}
