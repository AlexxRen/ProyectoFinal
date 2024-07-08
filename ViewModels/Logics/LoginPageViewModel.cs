using ProyectoFinal.Models;
using ProyectoFinal.Service.ServiciosMain;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProyectoFinal.Views.Main;
using Microsoft.Maui.Storage;
using ProyectoFinal.UsserControl;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ProyectoFinal.ViewModels.Logics
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string? _userName;
        [ObservableProperty]
        private string? _password;

        readonly ILogin InterfaceLogin = new LoginService();


        private async Task LoginAsync()
        {
            if (!string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(Password))
            {
                UserFZT userFZT = await InterfaceLogin.Login(UserName, Password);
                if (Preferences.ContainsKey(nameof(App.fZT)))
                {
                    Preferences.Remove(nameof(App.fZT));
                }
                string userDetails = JsonConvert.SerializeObject(userFZT);
                Preferences.Set(nameof(App.fZT), userDetails);
                App.fZT = userFZT;
                AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();
                await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
            }
        }
    }
}
