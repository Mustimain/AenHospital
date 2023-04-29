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
    public class PatientAnamesisService : IPatientAnamesisService
    {
        private List<PatientAnamesis> _patientAnamesis;
        public PatientAnamesisService() { 
        _patientAnamesis = new List<PatientAnamesis>();
            _patientAnamesis.Add(new PatientAnamesis
            {
                pTN = new BigInteger(202304270001),
                ComplaintTxt = "BAŞ AĞRISI",
                InvestigationTxt = "NORMAL",
                ResultTxt ="ORDER VERIİLDİ",

                
            });
            _patientAnamesis.Add(new PatientAnamesis
            {
                pTN = new BigInteger(202304270002),
                ComplaintTxt = "MİDE KANAMASI",
                InvestigationTxt = "AĞRILI",
                ResultTxt = "AMELİYAT ÖNERİLDİ",

                
            });

        }
        public async Task AddAnamesisAsync(PatientAnamesis patientAnamesis)
        {
             _patientAnamesis.Add(patientAnamesis);
        }

        public async Task<List<PatientAnamesis>> GetAnamesisByPtnAsync(BigInteger ptn)
        {
            var result = _patientAnamesis.Where(pt => pt.pTN == ptn).ToList();
            return result;
        }

        public async Task UpdateAnamesisAsync(PatientAnamesis patientAnamesis)
        {
            var result =  _patientAnamesis.Where(pt => pt == patientAnamesis).Select(pt => pt == patientAnamesis);
            
        }
    }
}
