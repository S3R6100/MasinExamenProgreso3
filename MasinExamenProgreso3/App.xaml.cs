using MasinExamenProgreso3.Data;

namespace MasinExamenProgreso3
{
    public partial class App : Application
    {
        public static ProductoRepository ProductoRepo { get; private set; }
        public static LogService LogServicio { get; private set; }

        public App(ProductoRepository repo, LogService logService)
        {
            InitializeComponent();

            ProductoRepo = repo;
            LogServicio = logService;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}