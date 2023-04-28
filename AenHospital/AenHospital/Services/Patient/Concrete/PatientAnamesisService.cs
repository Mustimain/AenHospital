using AenHospital.Models;
using AenHospital.Services.Patient.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AenHospital.Services.Patient.Concrete
{
    public class PatientAnamesisService : IPatientAnamesisService
    {
        public Task AddAnamesisAsync(PatientAnamesis patientAnamesis)
        {
            throw new NotImplementedException();
        }

        public Task<List<PatientAnamesis>> GetAnamesisByPtnAsync(string ptn)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAnamesisAsync(PatientAnamesis patientAnamesis)
        {
            throw new NotImplementedException();
        }
    }
}
