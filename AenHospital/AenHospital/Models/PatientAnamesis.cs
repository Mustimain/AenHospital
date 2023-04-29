using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace AenHospital.Models
{
    public class PatientAnamesis
    {
        public BigInteger pTN { get; set; }
        public string ComplaintTxt { get; set; }
        public string InvestigationTxt { get; set; }
        public string ResultTxt { get; set; }
    }
}
