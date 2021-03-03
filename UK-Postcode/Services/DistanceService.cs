using System;

namespace UK_Postcode.Services
{
    public enum DistanceUnit { MI, KM };

    public class DistanceService
    {
        private const double HeathrowLAT = 51.4700223;
        private const double HeathrowLON = -0.4542955;

        public double Distance(double latitude, double longitude, DistanceUnit unit)
        {
            double Radius = (unit == DistanceUnit.MI) ? 3960 : 6371;

            double dLat = Degree2Radian(HeathrowLAT - latitude);
            double dLon = Degree2Radian(HeathrowLON - longitude);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                Math.Cos(Degree2Radian(HeathrowLAT)) * Math.Cos(Degree2Radian(latitude)) *
                Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            return Radius * 2 * Math.Asin(Math.Min(1, Math.Sqrt(a)));
        }

        private double Degree2Radian(double val)
        {
            return (Math.PI / 180) * val;
        }
    }
}