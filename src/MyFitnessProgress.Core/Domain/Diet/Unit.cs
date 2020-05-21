using System;

namespace MyFitnessProgress.Core.Domain.Diet
{
    public class Unit
    {
        public int UnitId { get; set; }
        // Should be unique name.
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}