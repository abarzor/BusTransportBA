using BusTransport.Mob.TempModels;
using System.Collections.ObjectModel;

namespace BusTransport.Mob.ViewModels
{
    public class ReportProblemViewModel
    {
        public ObservableCollection<EventActionCategory> EventActionCategories { get; }
        public ReportProblemViewModel()
        {
            EventActionCategories = new ObservableCollection<EventActionCategory>
            {
                new EventActionCategory { Name = "Category 1" },
                new EventActionCategory { Name = "Category 2" },
            };
        }
    }
}