using AenHospital.Models;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AenHospital.Services.Patient.Interface
{
    public interface IPatientAnamesisService
    {
        // Hastaya ait anamesis listesi
        Task<List<PatientAnamesis>> GetAnamesisByPtnAsync(BigInteger ptn);
        // Anamesis güncelleme
        Task UpdateAnamesisAsync(PatientAnamesis patientAnamesis);
        // Anamesis ekleme
        Task AddAnamesisAsync(PatientAnamesis patientAnamesis);

    }
}
