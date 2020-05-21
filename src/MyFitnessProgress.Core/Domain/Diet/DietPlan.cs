using System;

namespace MyFitnessProgress.Core.Domain.Diet
{
    public class DietPlan
    {
        public int DietPlanId { get; set; }
        public TimeSpan From { get; set; }
        public TimeSpan To { get; set; }
        public bool IsDeleted { get; set; }
    }
}