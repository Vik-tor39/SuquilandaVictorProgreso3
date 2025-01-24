namespace SuquilandaVictorProgreso3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "Aeropuerto.db3");
            var repo = new AeropuertoRepository(dbPath);
            DependencyService.RegisterSingleton<IAeropuertoRepository>(repo);
            MainPage = new AppShell();
        }
    }
}
