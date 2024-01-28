using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTransport.Mobile.Services
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync(string username, string password);
    }
}
