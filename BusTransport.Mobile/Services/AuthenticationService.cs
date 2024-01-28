using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTransport.Mobile.Services
{
    public class AuthenticationService: IAuthenticationService
    {
        public async Task<bool> AuthenticateAsync(string username, string password)
        {
            // Simulate an API call with a delay
            await Task.Delay(1000);

            // Simple authentication: replace with actual logic
            return username == "user" && password == "pass";
        }
    }
}
