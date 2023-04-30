using AenHospital.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AenHospital.Services.Patient.Interface
{
    public interface ILogService
    {
        Task Log(T_Log t_Log);
        Task<List<T_Log>> GetAllLogs();
    }
}