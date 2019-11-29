using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grzadka.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconFileName { get; set; }
        public ICollection<Plant> Plants { get; set; }
    }
}