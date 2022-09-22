using Crud_UI.Models;
using System.Collections.Generic;

namespace CrudApi.DAL.Interface
{
    public interface IPositionDal
    {
        Position GetPositions(int positionId);
        bool AddPositions(Position position);
        bool RemovePositions(int positionId);
        bool UpdatePositions(Position position);
        List<Position> GetAllPositions();
    }
}
