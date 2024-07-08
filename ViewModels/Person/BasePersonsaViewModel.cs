using ProyectoFinal.ViewModels.Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models = ProyectoFinal.Models;
using CommunityToolkit.Mvvm.ComponentModel; 

namespace ProyectoFinal.ViewModels.Person
{
    public partial class BasePersonsaViewModel : BaseViewModel
    {
        [ObservableProperty]
        public Models.Persona? _persona; 
    }
}
