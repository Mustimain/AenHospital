using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace AenHospital.Models
{
    public class PatientPrescription
    {
        public BigInteger pTN { get; set; }
        public string Description { get; set; }
        public float Doze { get; set; }
        public string Usage { get; set; }


    }
}
