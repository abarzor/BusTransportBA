using BusTransport.Model.Models;

namespace BusTransport.DataAccess.Repository.IRepository
{
    public interface ITicketRepository : IRepository<Ticket>
    {
        void Update(Ticket obj);
    }
}
