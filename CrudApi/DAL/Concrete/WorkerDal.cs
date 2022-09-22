using Crud_UI.Models;
using Crud_UI.Models.Context;
using CrudApi.DAL.Interface;
using System.Collections.Generic;

namespace CrudApi.DAL.Concrete
{
    public class WorkerDal : IWorkerDal
    {
        BaseContext _baseContext;
        public WorkerDal(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }
        public bool AddWorkers(Workers workers)
        {
            throw new System.NotImplementedException();
        }

        public List<Workers> GetAllWorkers()
        {
            throw new System.NotImplementedException();
        }

        public Workers GetWorkers(int workerId)
        {
            throw new System.NotImplementedException();
        }

        public bool RemoveWorkers(int workerId)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateWorkers(Workers workers)
        {
            throw new System.NotImplementedException();
        }
    }
}
