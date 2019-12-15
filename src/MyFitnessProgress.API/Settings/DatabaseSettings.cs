namespace MyFitnessProgress.API.Settings
{
    public class DatabaseSettings
    {
        public string ConnectionString { get; set; }
        public bool UseInMemory { get; set; }
        public string DatabaseName { get; set; }
    }
}