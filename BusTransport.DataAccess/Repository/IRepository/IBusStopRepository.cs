using BusTransport.Model.Models;

namespace BusTransport.DataAccess.Repository.IRepository
{
    public interface IBusStopRepository : IRepository<BusStop>
    {
        void Update(BusStop obj);
    }
}
