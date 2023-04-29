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
    public class PatientOrderService : IPatientOrderService
    {
        private List<PatientOrder> _patientOrders;
        public PatientOrderService() { 
            _patientOrders = new List<PatientOrder>();

            _patientOrders.Add(new PatientOrder
            {
                pTN= new BigInteger(202304270001),
                OrderDate = DateTime.Now,
                Description= "ALDACTONE-A 25 MG TABLET",
                Quantity = 2,
                InfoTxt = "TEST ORDERI"

            });

            _patientOrders.Add(new PatientOrder
            {
                pTN = new BigInteger(202304270002),
                OrderDate = DateTime.Now,
                Description = "ALDACTONE-A 25 MG TABLET",
                Quantity = (float)3.5,
                InfoTxt = "TEST ORDERI"

            });
        }
        public async Task<List<PatientOrder>> GetPatientOrderListAsync(BigInteger ptn)
        {
            var result = _patientOrders.Where(ord => ord.pTN == ptn).ToList();

            return result;
        }
    }
}
