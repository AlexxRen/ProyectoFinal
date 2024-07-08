using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace ProyectoFinal.Service.ServiciosMain
{
    public class LoginService : ILogin
    {
        public async Task<UserFZT> Login(string user, string psw)
        {
            try
            {
                if (Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
                {
                    var userfzt = new UserFZT();
                    var client = new HttpClient();
                    string url = "https://181.199.59.60:80099/api/UserFZt/Loggin/" + user + "/" + psw;
                    client.BaseAddress = new Uri(url);
                    HttpResponseMessage response = await client.GetAsync("");
                    if (response.IsSuccessStatusCode)
                    {
                        userfzt = await response.Content.ReadFromJsonAsync<UserFZT>();
                        return userfzt;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
