using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WuzzyBears.Models
{
    public class WuzzyBearMaterialViewModel
    {
        public List<WuzzyBear> WuzzyBears { get; set; }
        public SelectList Materials { get; set; }
        public string TeddyMaterial { get; set; }

        public string SearchString { get; set; }
    }
}
