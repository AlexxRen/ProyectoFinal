using CommunityToolkit.Mvvm.ComponentModel;
using ProyectoFinal.ViewModels.Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.ViewModels.Rol
{
    public partial class BaseRolViewModel:BaseViewModel
    {
        [ObservableProperty]
        private Models.Role ?_role;
    }
}
