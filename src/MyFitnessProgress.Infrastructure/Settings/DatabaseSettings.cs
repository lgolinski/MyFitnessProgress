namespace MyFitnessProgress.Infrastructure.Settings
{
    public class DatabaseSettings : ISettings
    {
        public string ConnectionString { get; set; }
        public bool UseInMemoryDatabase { get; set; }
        public string DatabaseName { get; set; }
        public bool SeedData { get; set; }
        public bool UseMigrations { get; set; }
    }
}