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
                new BusStop { StopName = "Miejscowość 1", Arrival = new TimeOnly(8, 0), Departure = new TimeOnly(8, 5) },
                new BusStop { StopName = "Miejscowość 2", Arrival = new TimeOnly(8, 15), Departure = new TimeOnly(8, 20) },
                new BusStop { StopName = "Miejscowość 3", Arrival = new TimeOnly(8, 30), Departure = new TimeOnly(8, 35) },
                new BusStop { StopName = "Miejscowość 4", Arrival = new TimeOnly(8, 30), Departure = new TimeOnly(8, 35) },
                new BusStop { StopName = "Miejscowość 5", Arrival = new TimeOnly(8, 30), Departure = new TimeOnly(8, 35) },
                new BusStop { StopName = "Miejscowość 6", Arrival = new TimeOnly(15, 30), Departure = new TimeOnly(8, 35) },
                new BusStop { StopName = "Miejscowość 7", Arrival = new TimeOnly(16, 30), Departure = new TimeOnly(8, 35) },
                new BusStop { StopName = "Miejscowość 8", Arrival = new TimeOnly(17, 30), Departure = new TimeOnly(8, 35) },
                new BusStop { StopName = "Miejscowość 9", Arrival = new TimeOnly(18, 30), Departure = new TimeOnly(8, 35) },
            };
        }
    }
}
