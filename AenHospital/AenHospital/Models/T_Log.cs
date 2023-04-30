using System;
using System.Collections.Generic;
using System.Text;

namespace AenHospital.Models
{
    public class T_Log
    {
        public int Keyfield { get; set; }
        public string LogTipi { get; set; }
        public string Log { get; set; }
        public string UserCode { get; set; }
        public DateTime LogDate { get; set; }
    }
}
