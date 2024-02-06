using BusTransport.Model.Models;
using System.Collections.ObjectModel;

namespace BusTransport.Mob.ViewModels
{
    public class BusStopViewModel
    {
        public ObservableCollection<BusStop> BusStops { get; set; }
        public BusStopViewModel()
        {
            BusStops = new ObservableCollection<BusStop>
            {
                new BusStop { StopName = "Stop 1", Arrival = new TimeOnly(8, 0), Departure = new TimeOnly(8, 5) },
                new BusStop { StopName = "Stop 2", Arrival = new TimeOnly(8, 15), Departure = new TimeOnly(8, 20) },
                new BusStop { StopName = "Stop 3", Arrival = new TimeOnly(8, 30), Departure = new TimeOnly(8, 35) },
            };
        }
    }
}
