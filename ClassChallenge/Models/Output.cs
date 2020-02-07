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
        public Stats Stats { get; set; }
    }
}
