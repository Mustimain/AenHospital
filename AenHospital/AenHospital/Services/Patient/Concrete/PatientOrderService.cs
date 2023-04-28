using AenHospital.Models;
using AenHospital.Services.Patient.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AenHospital.Services.Patient.Concrete
{
    public class PatientOrderService : IPatientOrderService
    {
        public Task<List<PatientOrder>> GetPatientOrderListAsync(int ptn)
        {
            throw new NotImplementedException();
        }
    }
}
