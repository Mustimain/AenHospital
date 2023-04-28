using System;
using System.Collections.Generic;
using System.Text;

namespace AenHospital.Models
{
    public class PatientOrder
    {
        public string PatientCode { get; set; }
        public int PTN { get; set; }
        public DateTime OrderDate { get; set; }
        public string Description { get; set; }
        public int MyProperty { get; set; }
        public float Quantity { get; set; }
        public string InfoTxt { get; set; }

    }
}
