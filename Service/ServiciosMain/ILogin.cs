using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Service.ServiciosMain
{
    internal interface ILogin
    {
        Task<UserFZT> Login(string user, string psw);
    }
}
