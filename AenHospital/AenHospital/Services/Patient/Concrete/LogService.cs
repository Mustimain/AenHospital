using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using AenHospital.Models;
using AenHospital.Services.Patient.Interface;

namespace AenHospital.Services.Patient.Concrete
{
    public class LogService : ILogService
    {
        private List<T_Log> _logList;
        private readonly IPatientMastService _patientMastService;
        private readonly IHospitalMastService _hospitalMastService;
        public LogService(IPatientMastService patientMastService,IHospitalMastService hospitalMastService)
        {
            _hospitalMastService = hospitalMastService;
            _patientMastService = patientMastService;

            _logList = new List<T_Log>();
            _logList.Add(new T_Log
            {
                Keyfield = 1,
                Log = "Düzenleme Yapıldı",
                LogDate = DateTime.Now,
                LogTipi = Models.Enums.LogType.Ekleme,
                pTN = new BigInteger(546545646),
                UserCode = 1586
            });

            _logList.Add(new T_Log
            {
                Keyfield = 1,
                Log = "mevcut rapor güncellendi",
                LogDate = DateTime.Now,
                LogTipi = Models.Enums.LogType.Güncelleme,
                pTN = new BigInteger(1123123123),
                UserCode = 1586
            });

            _logList.Add(new T_Log
            {
                Keyfield = 1,
                Log = "Yeni reçete eklendi",
                LogDate = DateTime.Now,
                LogTipi = Models.Enums.LogType.Ekleme,
                pTN = new BigInteger(456456),
                UserCode = 1586
            });

            _logList.Add(new T_Log
            {
                Keyfield = 1,
                Log = "Anamnez Silme işlemi yapıldı",
                LogDate = DateTime.Now,
                LogTipi = Models.Enums.LogType.Silme,
                pTN = new BigInteger(456756756),
                UserCode = 1586
            });

        }

        public async Task<List<T_Log>> GetAllLogs()
        {
            if (_logList != null)
            {
                return _logList;

            }
            return new List<T_Log>();
        }

        public async Task<List<T_Log_Detail>> GetAllLogsDetail()
        {

            var log_Detail = new List<T_Log_Detail>();
            var user = Utils.UserInfo.CurrentUser;
            var hospital = Utils.UserInfo.SelectionHospital;
            foreach (var log in _logList)
            {
                var patient = await _patientMastService.GetPatientMastByIdAsync(log.pTN);
                log_Detail.Add(new T_Log_Detail
                {
                    Hospital = hospital,
                    Log = log,
                    User = user,
                    Patient = patient
                });
            }

            return log_Detail; ;
        }

        public async Task Log(T_Log t_Log)
        {
            _logList.Add(t_Log);
        }
    }
}
