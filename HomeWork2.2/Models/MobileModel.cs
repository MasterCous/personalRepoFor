using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeWork2._2.Models
{
    public class MobileModel
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public string Model { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime DateCreate { get; set; }
    }
}