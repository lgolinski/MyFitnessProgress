using System;

namespace MyFitnessProgress.Core.Domain.Diet
{
    public class DietPlanDetail
    {
        public int DietPlanDetailId { get; set; }
        public int DietPlanId { get; set; }
        public DietPlan DietPlan { get; set; }
        public bool IsDeleted { get; set; }
    }
}