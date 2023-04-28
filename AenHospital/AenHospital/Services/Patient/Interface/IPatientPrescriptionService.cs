using AenHospital.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AenHospital.Services.Patient.Interface
{
    public interface IPatientPrescriptionService
    {
        // Hastaya ait reçete listesi
        Task<List<PatientPrescription>> GetAllPatientPrescriptionByPtnAsync(string ptn);
    }
}
