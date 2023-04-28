using AenHospital.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AenHospital.Services.Auth
{
    public interface IAuthService
    {
        Task<bool> Login(string username,string password);
    }
}
