using BusTransport.DataAccess.Repository.IRepository;
using BusTransport.Model.Models;

namespace BusTransport.DataAccess.Repository
{
    public class PassengerRepository : Repository<Passenger>, IPassengerRepository
    {
        private ApplicationDbContext _db;
        public PassengerRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Passenger obj)
        {
            _db.Passengers.Update(obj);
        }
    }
}
