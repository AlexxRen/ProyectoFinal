using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Service.ServiciosRoles
{
    internal interface IRoles
    {
        Task<bool> AddUpdateRolAsync(Role role);
        Task<bool> DeLeteRolAsync(int IdRol);
        Task<Role> GetRolAsync(int IdRol);
        Task<IEnumerable<Role>> GetRolAsync();
    }
}
