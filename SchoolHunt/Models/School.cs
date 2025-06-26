using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolHunt.Models
{
    public class School
    {
        public int SchoolId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public string level { get; set; }
        public decimal TuitionFee { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

    }
}