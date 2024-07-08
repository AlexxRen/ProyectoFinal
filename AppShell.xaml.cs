using ProyectoFinal.Views.Main;
using ProyectoFinal.Views.Persona;

namespace ProyectoFinal
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            this.BindingContext = new AppShellViewModel();
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(AddPersonsaPage), typeof(HomePage));
        }
    }
}
