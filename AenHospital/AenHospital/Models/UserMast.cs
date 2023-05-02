using System;
using System.Collections.Generic;
using System.Text;

namespace AenHospital.Models
{
    public class UserMast
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public bool isAdmin { get; set; }
        public int PersonKey { get; set; }
        public int PersonType { get; set; }
        public int ResourceKey { get; set; }
    }
}
