using BusTransport.DataAccess.Repository.IRepository;

namespace BusTransport.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public IPassengerRepository Passenger { get; private set; }
        public ITicketRepository Ticket { get; private set; }
        public IDiscountRepository Discount { get; private set; }
        public IBusStopRepository BusStop { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Passenger = new PassengerRepository(_db);
            Ticket = new TicketRepository(_db);
            Discount = new DiscountRepository(_db);
            BusStop = new BusStopRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
