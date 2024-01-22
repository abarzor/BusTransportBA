using BusTransport.DataAccess.Repository.IRepository;
using BusTransport.Model.Models;

namespace BusTransport.DataAccess.Repository
{
    public class BusStopRepository : Repository<BusStop>, IBusStopRepository
    {
        private ApplicationDbContext _db;
        public BusStopRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(BusStop obj)
        {
            _db.BusStops.Update(obj);
        }
    }
}
