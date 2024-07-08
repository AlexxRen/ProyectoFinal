using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Service.ServiciosCamara
{
    public interface ICamara
    {
        Task<bool> AddUpdateCamaraAsync(CamaraEcu911 camara);
        Task<bool> DeLeteCamaraAsync(int IdCamara);
        Task<CamaraEcu911> GetCamaraAsync(int IdCamara);
        Task<IEnumerable<CamaraEcu911>> GetCamaraAsync();
    }
}
