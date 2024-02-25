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
                new EventActionCategory { Name = "Problemy techniczne z pojazdem" },
                new EventActionCategory { Name = "Problem z pasażerem" },
                new EventActionCategory { Name = "Warunki pogodowe" },
                new EventActionCategory { Name = "Inne zdarzenie losowe" },
            };
        }
        public class EventActionCategory
        {
            public string Name { get; set; }
        }
    }
}
