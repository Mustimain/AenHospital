using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AenHospital.Models
{

    public class HospitalMast
    {
        public int Keyfield { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
