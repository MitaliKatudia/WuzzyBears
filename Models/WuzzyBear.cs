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


        [StringLength(15, MinimumLength = 5)]
        [Required]
        [Display(Name = "Teddy's serial Number")]
        public string TeddySerialNumber { get; set; }


        [Display(Name = "Type Of Teddy Bear")]
        [StringLength(50, MinimumLength = 5)]
        [Required]
        public string TypeOfTeddy { get; set; }


        [Display(Name = "Material Of Teddy")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(50)]
        public string MaterialOfTeddy { get; set; }


        [DataType(DataType.Date)]
        public DateTime Manufactured { get; set; }


        [Display(Name = "Size Of Teddy Bear in 'cms'")]
        public int SizeOfTeddy { get; set; }


        [Display(Name = "Cost Of Teddy Bear")]
        [Range(1, 50)]
        [DataType(DataType.Currency)]
       // [CurrencyDisplay("en-us")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal CostOfTeddy { get; set; }


        [Range(1, 5)]
        [Required]
        public int CustomerRating { get; set; }
    }
}
