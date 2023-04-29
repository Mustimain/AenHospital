using AenHospital.Models;
using AenHospital.Services.Auth;
using AenHospital.Services.Patient.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AenHospital.Services.Patient.Concrete
{
    public class PatientMastService : IPatientMastService
    {
        private List<PatientMast> _Patients;
        public PatientMastService() {

            _Patients = new List<PatientMast>();
            _Patients.Add(new PatientMast
            {
                PersonKey = 1586,
                PTN = "202304270001",
                PatientCode="07000008",
                Patient = "Mustafa Ceylan",
                Gender = "M",
                Age = 25,
                FloorNo = "2. KAT",
                BedKey = 288,

            });

            _Patients.Add(new PatientMast
            {
                PersonKey = 1586,
                PTN = "202304270002",
                PatientCode = "07000009",
                Patient = "Gokhan Koc",
                Gender = "M",
                Age = 35,
                FloorNo = "2. KAT",
                BedKey = 289,

            });

            _Patients.Add(new PatientMast
            {
                PersonKey = 1530,
                PTN = "202304270004",
                PatientCode = "07000010",
                Patient = "Cansu Oztekin",
                Gender = "F",
                Age = 22,
                FloorNo = "3. KAT",
                BedKey = 322,

            });
        }
        public async Task<List<PatientMast>> GetAllPatientMastAsync(int personKey)
        {
            var result = _Patients.Where(pt => pt.PersonKey == Utils.UserInfo.CurrentUser.PersonKey).ToList();
            return result;
        }
    }
}
