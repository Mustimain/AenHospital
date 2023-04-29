using AenHospital.Base;
using AenHospital.Models;
using AenHospital.Services.Patient.Interface;
using Prism.AppModel;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AenHospital.ViewModels.Patients.PatientOrder
{
    public class PatientOrderPageViewModel : BaseViewModel, INavigationAware, IPageLifecycleAware, IInitialize
    {
        private readonly IPatientOrderService _patientOrderService;
        public PatientOrderPageViewModel(INavigationService service,IPatientOrderService patientOrderService) : base(service)
        {
            _patientOrderService = patientOrderService;
        }

        private ObservableCollection<Models.PatientOrder> _patientOrders = new ObservableCollection<Models.PatientOrder>();
        public ObservableCollection<Models.PatientOrder> PatientOrders
        {
            get
            {
                return _patientOrders;
            }
            set
            {
                _patientOrders = value; RaisePropertyChanged();
            }
        }

        public async void Initialize(INavigationParameters parameters)
        {
            var param = parameters.GetValue<PatientMast>("selectionPatient");
            if (parameters.ContainsKey("selectionPatient"))
            {
                var result = await _patientOrderService.GetPatientOrderListAsync(param.pTN);

                result.ForEach(ordr => PatientOrders.Add(ordr));
            }
        }

        public ICommand BackCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await navigationService.GoBackAsync();
                });
            }
        }

        public ICommand EditCommand
        {
            get
            {
                return new Command(async () =>
                {
                });
            }
        }


    }

    
}
