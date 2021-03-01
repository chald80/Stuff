using InClass_LINQ.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InClass_LINQ.Services
{
    class StudioCatalog
    {
        List<Studio> studios;
        public StudioCatalog()
        {
            studios = new List<Studio>();
            studios.Add(new Studio() { Name = "New Line Cinema", HQCity = "Boston", NoOfEmployees = 4000 });
            studios.Add(new Studio() { Name = "20th Century Fox", HQCity = "New York", NoOfEmployees = 2500 });
            studios.Add(new Studio() { Name = "Paramount  Pictures", HQCity = "New York", NoOfEmployees = 8000 });
        }
        public IEnumerable<Studio> GetStudios()
        {
            return studios;
        }
        }
    }
