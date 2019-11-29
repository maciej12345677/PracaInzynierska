using Grzadka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grzadka.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Plant> Bestsellers { get; set; }
        public IEnumerable<Plant> NewArrivals { get; set; } //nowododane
        public IEnumerable<Category> Categories { get; set; } 
    }
}