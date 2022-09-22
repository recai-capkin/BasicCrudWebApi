using Crud_UI.Models;
using Crud_UI.Models.Context;
using CrudApi.DAL.Interface;
using System.Collections.Generic;
using System.Linq;

namespace CrudApi.DAL.Concrete
{
    public class FactoryDal : IFactoryDal
    {
        BaseContext _baseContext;
        public FactoryDal(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }
        public bool AddFactories(Factory factory)
        {
            _baseContext.Factories.Add(factory);
            return _baseContext.SaveChanges()>0;
        }

        public List<Factory> GetAllFactories()
        {
            List<Factory> factories = _baseContext.Factories.ToList();
            return factories;
        }

        public Factory GetFactories(int factoryId)
        {
            Factory data = _baseContext.Factories.Where(x => x.FactoryId == factoryId).FirstOrDefault();
            return data;
        }

        public bool RemoveFactories(int factoryId)
        {
            Factory data = _baseContext.Factories.Where(x => x.FactoryId == factoryId).FirstOrDefault();
             _baseContext.Factories.Remove(data);
            return _baseContext.SaveChanges() > 0;
        }

        public bool UpdateFactories(Factory factory)
        {
            Factory data = GetFactories(factory.FactoryId);
            data = new Factory()
            {
                FactoryName = factory.FactoryName
            };
            return _baseContext.SaveChanges()>0;
        }
    }
}
