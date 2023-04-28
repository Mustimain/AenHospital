using AenHospital.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AenHospital.Utils
{
    public static class UserInfo
    {
        public static UserMast CurrentUser { get; set; }
        public static HospitalMast SelectionHospital { get; set; }
    }
}
