namespace BusTransport.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IPassengerRepository Passenger { get; }
        ITicketRepository Ticket { get; }
        IDiscountRepository Discount { get; }
        IBusStopRepository BusStop { get; }

        void Save();//Global method
    }
}
