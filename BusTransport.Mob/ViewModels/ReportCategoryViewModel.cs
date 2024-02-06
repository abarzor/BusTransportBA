using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTransport.Mob.ViewModels
{
    public class ReportCategoryViewModel
    {
        public ObservableCollection<EventActionCategory> EventActionCategories { get; }

        public ReportCategoryViewModel()
        {
            EventActionCategories = new ObservableCollection<EventActionCategory>
            {
                new EventActionCategory { Name = "Category 1" },
                new EventActionCategory { Name = "Category 2" },
                // Add more categories as needed
            };
        }
        public class EventActionCategory
        {
            public string Name { get; set; }
        }
    }
}
