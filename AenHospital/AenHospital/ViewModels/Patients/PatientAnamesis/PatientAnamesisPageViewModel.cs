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

namespace AenHospital.ViewModels.Patients.PatientAnamesis
{
    public class PatientAnamesisPageViewModel : BaseViewModel, INavigationAware, IPageLifecycleAware,IInitialize
    {
        private readonly IPatientAnamesisService _patientAnamnesisService;
        public PatientAnamesisPageViewModel(INavigationService service,IPatientAnamesisService patientAnamesisService) : base(service)
        {
            _patientAnamnesisService = patientAnamesisService;
        }

        private ObservableCollection<Models.PatientAnamesis> _patientAnamnesiss = new ObservableCollection<Models.PatientAnamesis>();
        public ObservableCollection<Models.PatientAnamesis> PatientAnamnesiss
        {
            get
            {
                return _patientAnamnesiss;
            }
            set
            {
                _patientAnamnesiss = value; RaisePropertyChanged();
            }
        }


        public async void OnAppearing()
        {

        }
        
        public async void Initialize(INavigationParameters parameters)
        {
            var param = parameters.GetValue<PatientMast>("selectionPatient");
            if (parameters.ContainsKey("selectionPatient"))
            {
                var result = await _patientAnamnesisService.GetAnamesisByPtnAsync(param.pTN);

                result.ForEach(ans => PatientAnamnesiss.Add(ans));
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
