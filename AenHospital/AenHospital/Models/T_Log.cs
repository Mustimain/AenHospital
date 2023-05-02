using AenHospital.Models.Enums;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace AenHospital.Models
{
    public class T_Log
    {
        public int Keyfield { get; set; }
        public LogType LogTipi { get; set; }
        public string Log { get; set; }
        public int UserCode { get; set; }
        public DateTime LogDate { get; set; }
        public BigInteger pTN  { get; set; }
    }
}
