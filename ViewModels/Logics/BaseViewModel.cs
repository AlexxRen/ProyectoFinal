using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ProyectoFinal.ViewModels.Logics
{
    public partial class BaseViewModel: ObservableObject
    {
        [ObservableProperty]
        public bool _isbusy;
        [ObservableProperty]
        public string? _tile;
    }
}
