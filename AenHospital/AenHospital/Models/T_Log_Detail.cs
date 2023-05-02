using System;
using System.Collections.Generic;
using System.Text;

namespace AenHospital.Models
{
    public class T_Log_Detail
    {
        public HospitalMast Hospital { get; set; }
        public T_Log Log { get; set; }
        public UserMast User { get; set; }
        public PatientMast Patient { get; set; }
    }
}
