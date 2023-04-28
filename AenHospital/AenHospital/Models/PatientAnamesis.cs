using System;
using System.Collections.Generic;
using System.Text;

namespace AenHospital.Models
{
    public class PatientAnamesis
    {
        public string PatientCode { get; set; }
        public string PTN { get; set; }
        public string ComplaintTxt { get; set; }
        public string InvestigationTxt { get; set; }
        public string ResultTxt { get; set; }
    }
}
