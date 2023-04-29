using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace AenHospital.Models
{
    public class PatientOrder
    {
        public BigInteger pTN { get; set; }
        public DateTime OrderDate { get; set; }
        public string Description { get; set; }
        public float Quantity { get; set; }
        public string InfoTxt { get; set; }

    }
}
