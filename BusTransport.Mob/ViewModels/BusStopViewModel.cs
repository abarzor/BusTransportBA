using BusTransport.Model.Models;
using System.Collections.ObjectModel;

namespace BusTransport.Mob.ViewModels
{
    public class BusStopViewModel
    {
        public ObservableCollection<BusStop> BusStops { get; set; } //ObservableCollection
        public BusStopViewModel()
        {
            BusStops = new ObservableCollection<BusStop>
            {
                new BusStop { StopName = "Warszawa", Arrival = new TimeOnly(8, 0), Departure = new TimeOnly(8, 5) },
                new BusStop { StopName = "Pruszków", Arrival = new TimeOnly(8, 35), Departure = new TimeOnly(8, 40) },
                new BusStop { StopName = "Żyrardów", Arrival = new TimeOnly(9, 10), Departure = new TimeOnly(9, 15) },
                new BusStop { StopName = "Skierniewice", Arrival = new TimeOnly(9, 45), Departure = new TimeOnly(9, 50) },
                new BusStop { StopName = "Łowicz", Arrival = new TimeOnly(10, 20), Departure = new TimeOnly(10, 25) },
                new BusStop { StopName = "Sieradz", Arrival = new TimeOnly(10, 55), Departure = new TimeOnly(11, 0) },
                new BusStop { StopName = "Wieluń", Arrival = new TimeOnly(11, 30), Departure = new TimeOnly(11, 35) },
                new BusStop { StopName = "Olesno", Arrival = new TimeOnly(12, 5), Departure = new TimeOnly(12, 10) },
                new BusStop { StopName = "Opole", Arrival = new TimeOnly(12, 40), Departure = new TimeOnly(12, 45) },
                new BusStop { StopName = "Nysa", Arrival = new TimeOnly(13, 15), Departure = new TimeOnly(13, 20) },
                new BusStop { StopName = "Kudowa-Zdrój", Arrival = new TimeOnly(13, 50), Departure = new TimeOnly(13, 55) }
            };
        }
    }
}