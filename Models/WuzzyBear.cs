using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WuzzyBears.Models
{
    public class WuzzyBear
    {
        public int Id { get; set; }
        public string TeddySerialNumber { get; set; }

        public string TypeOfTeddy { get; set; }

        public string MaterialOfTeddy { get; set; }


        [DataType(DataType.Date)]
        public DateTime Manufactured { get; set; }

        public int SizeOfTeddy { get; set; }

        public decimal CostOfTeddy { get; set; }
    }
}
