using BusTransport.DataAccess.Repository.IRepository;
using BusTransport.Model.Models;

namespace BusTransport.DataAccess.Repository
{
    public class DiscountRepository : Repository<Discount>, IDiscountRepository
    {
        private ApplicationDbContext _db;
        public DiscountRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Discount obj)
        {
            _db.Discounts.Update(obj);
        }
    }
}
