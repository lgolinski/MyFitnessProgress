namespace MyFitnessProgress.API.Settings
{
    public class DatabaseSettings
    {
        public string ConnectionString { get; set; }
        public bool UseInMemoryDatabase { get; set; }
        public string DatabaseName { get; set; }
        public bool SeedData { get; set; }
    }
}