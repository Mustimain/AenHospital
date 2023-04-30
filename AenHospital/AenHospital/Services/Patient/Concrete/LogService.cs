using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AenHospital.Models;
using AenHospital.Services.Patient.Interface;

namespace AenHospital.Services.Patient.Concrete
{
    public class LogService : ILogService
    {
        private List<T_Log> _logList;
        public LogService()
        {
            _logList = new List<T_Log>();

        }

        public async Task<List<T_Log>> GetAllLogs()
        {
            return _logList;

        }

        public async Task Log(T_Log t_Log)
        {
            _logList.Add(t_Log);
        }
    }
}
