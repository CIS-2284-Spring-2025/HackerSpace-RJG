using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class SpeedFeedCalc
    {
        [Required]
        [Range(0, 100000)]
        public double RPM { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double Diam { get; set; }

        public double GetSFM()
        {
            return RPM * Diam / 3.82;
        }
    }
}
