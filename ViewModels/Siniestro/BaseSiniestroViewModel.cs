using CommunityToolkit.Mvvm.ComponentModel;
using ProyectoFinal.ViewModels.Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.ViewModels.Siniestro
{
    public partial class BaseSiniestroViewModel:BaseViewModel
    {
        [ObservableProperty]
        private Models.Siniestro ?_siniestro;
    }
}
