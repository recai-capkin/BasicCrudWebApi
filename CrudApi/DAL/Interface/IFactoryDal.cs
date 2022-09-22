using Crud_UI.Models;
using System.Collections.Generic;

namespace CrudApi.DAL.Interface
{
    public interface IFactoryDal
    {
        Factory GetFactories(int factoryId);
        bool AddFactories(Factory factory);
        bool RemoveFactories(int factoryId);
        bool UpdateFactories(Factory factory);
        List<Factory> GetAllFactories();
    }
}
