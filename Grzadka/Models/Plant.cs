using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grzadka.Models
{
    public class Plant
    {
        public int PlantId{ get; set; }
        public int CategoryId { get; set; }
        public string PlantName { get; set; }

        public int StandPoint { get; set; }
        public int Humidity { get; set; }
        public int Size { get; set; }
        public int Decoration { get; set; }
        public int Growth { get; set; }
        public int Spitz { get; set; } //zraszanie
        public int Rambling { get; set; } //pnąca
        public int Difficulty { get; set; } //uprawa

        public DateTime DateAdded { get; set; }
        public string CoverFileName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsBestseller { get; set; }
        public bool IsHidden { get; set; }

        public virtual Category Category{ get; set; }

    }
}