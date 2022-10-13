using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WuzzyBears.Models
{
    public class WuzzyBear
    {
        public int Id { get; set; }

        [Display(Name = "Teddy's serial Number")]
        public string TeddySerialNumber { get; set; }

        [Display(Name = "Type Of Teddy Bear")]
        public string TypeOfTeddy { get; set; }

        [Display(Name = "Material Of Teddy")]
        public string MaterialOfTeddy { get; set; }


        [DataType(DataType.Date)]
        public DateTime Manufactured { get; set; }

        [Display(Name = "Size Of Teddy Bear in 'cms'")]
        public int SizeOfTeddy { get; set; }

        [Display(Name = "Cost Of Teddy Bear")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal CostOfTeddy { get; set; }

        [Range(1, 5)]
        public int CustomerRating { get; set; }
    }
}
