using fekon_repository_datamodel.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fekon_repository_api
{
    public interface ICollectionService
    {
        string AddNewRefCollection(RefCollection rc);
        string AddNewSubColl(CollectionD collectionD);
        string DeleteRefCollection(long id);
        string DeleteSubcoll(long id);
        string EditRefCollection(RefCollection rc);
        string EditSubColl(CollectionD collectionD);
        CollectionD FindCollectionDById(long id);
        RefCollection FindRefCollectionByCode(string code);
        RefCollection FindRefCollectionByCollDId(long id);
        Task<IEnumerable<CollectionD>> GetCollectionDAsync();
        Task<IEnumerable<CollectionD>> GetCollectionDsByRefCollIdAsync(long id);
        Task<IEnumerable<Community>> GetCommunitiesAsync();
        RefCollection GetRefCollectionById(long id);
        Task<IEnumerable<RefCollection>> GetRefCollectionsAsyncForAddRepo();
        IQueryable<RefCollection> GetRefCollectionsForPaging(string query);
        Task<IEnumerable<RefCollection>> GetRefCollectionsForSideMenu();
        CollectionD GetSubCollectionById(long id);
        IQueryable<CollectionD> GetSubCollForPaging(string query);
    }
}
