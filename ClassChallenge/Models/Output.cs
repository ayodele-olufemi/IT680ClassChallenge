using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassChallenge.Models
{
    public class Output
    {
        public List<string> ListOfColleges { get; set; }
        public List<string> ListOfDepartments { get; set; }
        public List<string> ListOfUnits { get; set; }
        public Stats OverallStats { get; set; }
        public Stats CollegesStats { get; set; }
        public Stats UnitsStats { get; set; }
        public Stats DepartmentsStats { get; set; }
    }
}
