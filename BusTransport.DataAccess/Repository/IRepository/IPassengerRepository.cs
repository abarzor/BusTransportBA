using BusTransport.Model.Models;

namespace BusTransport.DataAccess.Repository.IRepository
{
    public interface IPassengerRepository : IRepository<Passenger>
    {
        void Update(Passenger obj);
    }
}
