using AenHospital.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AenHospital.Services.Patient.Interface
{
    public interface IPatientOrderService
    {
        // Hasta istekleri listesi
        Task<List<PatientOrder>> GetPatientOrderListAsync(int ptn);
    }
}
