using System;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace MyFitnessProgress.Infrastructure.Extensions.EntityFramework
{
    public class CreationDateValueGenerator : ValueGenerator<DateTime>
    {
        public override DateTime Next(EntityEntry _) => DateTime.UtcNow;

        public override bool GeneratesTemporaryValues => false;
    }
}