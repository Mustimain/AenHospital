using AenHospital.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AenHospital.Services.Patient.Interface
{
    public interface IPatientMastService
    {
        // Giriş yapan kullanıcının hastalarının listesi
        Task<List<PatientMast>> GetAllPatientMastAsync(int personKey);
        
    }
}
