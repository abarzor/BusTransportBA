using BusTransport.Model.Models;

namespace BusTransport.DataAccess.Repository.IRepository
{
    public interface IDiscountRepository : IRepository<Discount>
    {
        void Update(Discount obj);
    }
}
