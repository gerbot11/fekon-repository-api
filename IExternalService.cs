using fekon_repository_datamodel.MobileModel;
using fekon_repository_datamodel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fekon_repository_api
{
    public interface IExternalService
    {
        List<MobileIndex> GetRepositoryIndex();
    }
}
