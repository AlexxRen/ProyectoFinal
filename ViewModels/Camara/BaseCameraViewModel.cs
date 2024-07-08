using CommunityToolkit.Mvvm.ComponentModel;
using ProyectoFinal.ViewModels.Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.ViewModels.Camara
{
    public partial class BaseCameraViewModel:BaseViewModel
    {
        [ObservableProperty]
        private Models.CamaraEcu911 ?_camara;
    }
}
