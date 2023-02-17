using System;
using System.ComponentModel.DataAnnotations;

namespace Magnets.Models
{
    public class Magnet
    {
        public int Id { get; set; }
        public string MagnetNames { get; set; }
        public string Material { get; set; }
      


        public string Applications { get; set; }
        public string Strength { get; set; }
        public int Rating { get; set; }


        public decimal Price { get; set; }
    }
}