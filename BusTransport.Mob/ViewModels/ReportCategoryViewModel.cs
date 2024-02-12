using System.Collections.ObjectModel;

namespace BusTransport.Mob.ViewModels
{
    public class ReportCategoryViewModel
    {
        public ObservableCollection<EventActionCategory> EventActionCategories { get; }

        public ReportCategoryViewModel()
        {
            EventActionCategories = new ObservableCollection<EventActionCategory>
            {
                new EventActionCategory { Name = "Zdarzenie na drodze" },
                new EventActionCategory { Name = "Awaria pojazdu" },
                new EventActionCategory { Name = "Inna kategoria 1" },
                new EventActionCategory { Name = "Inna kategoria 2" },
                new EventActionCategory { Name = "Inna kategoria 3" },
                new EventActionCategory { Name = "Inna kategoria 4" },
            };
        }
        public class EventActionCategory
        {
            public string Name { get; set; }
        }
    }
}
