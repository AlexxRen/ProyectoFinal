using ProyectoFinal.ViewModels.Logics;
using Microsoft.Maui.Controls;

namespace ProyectoFinal.Views.Main
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage(LoginPageViewModel loginPageViewModel)
        {
            InitializeComponent();
            this.BindingContext = loginPageViewModel;
        }
    }
}
