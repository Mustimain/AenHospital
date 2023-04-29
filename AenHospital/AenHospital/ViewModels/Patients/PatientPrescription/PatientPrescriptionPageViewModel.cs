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

namespace AenHospital.ViewModels.Patients.PatientPrescription
{
    public class PatientPrescriptionPageViewModel : BaseViewModel, INavigationAware, IPageLifecycleAware,IInitialize
    {
        private readonly IPatientPrescriptionService _patientPrescriptionService;
        public PatientPrescriptionPageViewModel(INavigationService service,IPatientPrescriptionService patientPrescriptionService) : base(service)
        {
            _patientPrescriptionService = patientPrescriptionService;
        }

        private ObservableCollection<Models.PatientPrescription> _patientPrescriptions = new ObservableCollection<Models.PatientPrescription>();
        public ObservableCollection<Models.PatientPrescription> PatientPrescriptions
        {
            get
            {
                return _patientPrescriptions;
            }
            set
            {
                _patientPrescriptions = value; RaisePropertyChanged();
            }
        }

        

        public async void Initialize(INavigationParameters parameters)
        {
            var param = parameters.GetValue<PatientMast>("selectionPatient");
            if (parameters.ContainsKey("selectionPatient"))
            {
                var result = await _patientPrescriptionService.GetAllPatientPrescriptionByPtnAsync(param.pTN);

                result.ForEach(prs => PatientPrescriptions.Add(prs));
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
