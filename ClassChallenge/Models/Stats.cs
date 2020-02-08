using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClassChallenge.Models
{
    public class Stats
    {
        [DataType(DataType.Currency)]
        public double Average { get; set; }

        [DataType(DataType.Currency)]
        public double Max { get; set; }

        [DataType(DataType.Currency)]
        public double Min { get; set; }

        [DataType(DataType.Currency)]
        public double Median { get; set; }
    }
}
