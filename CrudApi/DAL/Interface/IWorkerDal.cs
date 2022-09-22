using Crud_UI.Models;
using System.Collections.Generic;

namespace CrudApi.DAL.Interface
{
    public interface IWorkerDal
    {
        Workers GetWorkers(int workerId);
        bool AddWorkers(Workers workers);
        bool RemoveWorkers(int workerId);
        bool UpdateWorkers(Workers workers);
        List<Workers> GetAllWorkers();

    }
}
