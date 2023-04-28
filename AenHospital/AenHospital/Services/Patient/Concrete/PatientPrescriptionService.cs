using AenHospital.Models;
using AenHospital.Services.Patient.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AenHospital.Services.Patient.Concrete
{
    public class PatientPrescriptionService : IPatientPrescriptionService
    {
        public Task<List<PatientPrescription>> GetAllPatientPrescriptionByPtnAsync(string ptn)
        {
            throw new NotImplementedException();
        }
    }
}
