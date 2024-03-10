// HealthMetrics/HealthMetric.cs
// TODO: Construct the HealthMetric entity to store user health data points.

namespace VitaSync.Core.Domain.HealthMetrics
{
    public class HealthMetric
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double BMI { get; set; }
        public double BodyFatPercentage { get; set; }
        public double MuscleMassPercentage { get; set; }
        public double WaterPercentage { get; set; }
        public double BoneDensity { get; set; }
        public double VisceralFat { get; set; }
        public double BMR { get; set; }
        public double MetabolicAge { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

