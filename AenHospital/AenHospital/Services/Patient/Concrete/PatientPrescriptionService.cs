using AenHospital.Models;
using AenHospital.Services.Patient.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AenHospital.Services.Patient.Concrete
{
    public class PatientPrescriptionService : IPatientPrescriptionService
    {
        private List<PatientPrescription> _patientPrescriptionList;
        public PatientPrescriptionService()
        {
            _patientPrescriptionList = new List<PatientPrescription>();

            _patientPrescriptionList.Add(new PatientPrescription
            {
                pTN = new BigInteger(202304270001),
                Description = "DELODAY 0.5 MG/ML 150 ML SURUP",
                Doze = 2,
                Usage = "Diğer"
            }) ;

            _patientPrescriptionList.Add(new PatientPrescription
            {
                pTN = new BigInteger(202304270001),
                Description = "AUGMENTIN BID 1000 MG.14 FILM TB.",
                Doze = 3,
                Usage = "Ağızdan"
            });

            _patientPrescriptionList.Add(new PatientPrescription
            {
                pTN = new BigInteger(202304270001),
                Description = "KLOROBEN 1,5 MG/ML + 1,2 MG/ML ORAL SPREY, COZELTI, 30 ML",
                Doze = 1,
                Usage = "Diğer"
            });

            _patientPrescriptionList.Add(new PatientPrescription
            {
                pTN = new BigInteger(202304270002),
                Description = "Deneme Hapı 345",
                Doze = 5,
                Usage = "Ağızdan"
            });

            _patientPrescriptionList.Add(new PatientPrescription
            {
                pTN = new BigInteger(202304270002),
                Description = "Deneme hapı 123",
                Doze = 7,
                Usage = "Ağızdan"
            });
        }
        public async Task<List<PatientPrescription>> GetAllPatientPrescriptionByPtnAsync(BigInteger ptn)
        {
            var result = _patientPrescriptionList.Where(prs => prs.pTN == ptn).ToList();
            return result;
        }
    }
}
