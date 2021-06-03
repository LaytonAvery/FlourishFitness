using System;
using System.ComponentModel.DataAnnotations;

namespace FlourishFitness.Pages
{
    public class Bmi
    {
        public int UserId { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}