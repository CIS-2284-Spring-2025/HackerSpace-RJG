using System.ComponentModel.DataAnnotations;

namespace HackerSpace.Data.Models
{
    public class SpeedFeedCalc
    {
        private double rpm;

        [Required]
        [Range(0, 100000)]
        public double RPM 
        {
            get { return rpm; }
            set { rpm = value; CalculateSFM(); }
        }

        private double diam;
        [Required]
        [Range(0,double.MaxValue)]
        public double Diam
        {
            get { return diam; }
            set { diam = value; CalculateSFM(); }
        }

        public double SFM { get; private set; }

        private void CalculateSFM()
        {
            SFM = rpm * diam / 3.82;
        }
    }
}
