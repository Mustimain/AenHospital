using System;
using System.Collections.Generic;
using System.Text;

namespace AenHospital.Models
{
    public class PatientMast
    {
        public int PersonKey { get; set; }
        public string PTN { get; set; }
        public string PatientCode { get; set; }
        public string Patient { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string FloorNo { get; set; }
        public int BedKey { get; set; }


    }
}
