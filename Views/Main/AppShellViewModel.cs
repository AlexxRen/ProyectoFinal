using CommunityToolkit.Mvvm.Input;
using ProyectoFinal.ViewModels.Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Views.Main
{
    public partial class  AppShellViewModel :BaseViewModel
    {

        async void Finishout()
        {
            if (Preferences.ContainsKey(nameof(App.fZT)))
            {
                Preferences.Remove(nameof(App.fZT));
            }
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
