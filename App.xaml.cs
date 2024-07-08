using ProyectoFinal.Models;
using ProyectoFinal.Service.Models;
using ProyectoFinal.Service.ServiciosPersona;

namespace ProyectoFinal
{
    public partial class App : Mauiw
    {
        public static UserFZT? fZT; 
        private static PersonaService? _perService;

        public static PersonaService PersonaService
        {
            get
            {
                if (_perService == null)
                {
                    _perService = new PersonaService(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LocalDatabase.db3"));
                }
                return _perService;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }
    }
}
