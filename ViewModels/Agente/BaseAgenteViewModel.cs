using CommunityToolkit.Mvvm.ComponentModel;
using ProyectoFinal.ViewModels.Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.ViewModels.Agente
{
    public partial class BaseAgenteViewModel: BaseViewModel
    {
        [ObservableProperty]
        private Models.Agente? _agente;
    }
}
