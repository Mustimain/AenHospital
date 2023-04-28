using AenHospital.Models;
using AenHospital.Services.Patient.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AenHospital.Services.Patient.Concrete
{
    public class HospitalMastService : IHospitalMastService
    {
        private List<HospitalMast> _Hospitals = new List<HospitalMast>();

        public HospitalMastService()
        {
            _Hospitals.Add(new HospitalMast
            {
                Keyfield =1,
                Code = "Anıt2020",
                Description = "Anıt 2020",
            });

            _Hospitals.Add(new HospitalMast
            {
                Keyfield = 3,
                Code = "Medware",
                Description = "Medware",
            });
        }

        public async Task<List<HospitalMast>> GetAllHospitalsAsync()
        {
            return _Hospitals;
        }
    }
}
