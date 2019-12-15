using System;

namespace MyFitnessProgress.Core.Domain.Diet
{
    public class Picture
    {
        public int PictureId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        public bool IsDeleted { get; set; }
    }
}