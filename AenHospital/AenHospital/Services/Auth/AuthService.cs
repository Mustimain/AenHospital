using AenHospital.Database;
using AenHospital.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using AenHospital.Utils;

namespace AenHospital.Services.Auth
{
    public class AuthService : IAuthService
    {
        private List<UserMast> users;
        public AuthService() {

            users = new List<UserMast>();
        users.Add(new UserMast
        {
            Username="gkoc",
            Password = "1453",
            Description = "Gokhan Koc",
            isAdmin = true,
            PersonKey = 1586,
            PersonType = 99,
            ResourceKey = 1
                 
        });
            users.Add(new UserMast
            {
                Username = "mceylan",
                Password = "musti123",
                Description = "Mustafa Ceylan",
                isAdmin = true,
                PersonKey = 1530,
                PersonType = 79,
                ResourceKey = 2

            });

        }
        public async Task<bool> Login(string username, string password)
        {
            foreach (var user in users)
            {
                if (user.Username.ToLower().Contains(username.ToLower()) && user.Password.ToLower().Contains(password.ToLower()))
                {
                   UserInfo.CurrentUser = user;
                    return true;

                }
                else
                {
                    return false;
                }
            }
            return false;
           
        }
    }
}
