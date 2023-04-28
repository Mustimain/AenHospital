using AenHospital.Base;
using AenHospital.Models;
using AenHospital.Services.Patient.Interface;
using Prism.AppModel;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AenHospital.ViewModels.Patients
{
    public class PatientsPageViewModel : BaseViewModel, IInitialize, IPageLifecycleAware, INavigatedAware
    {

       private readonly IPatientMastService _patientMastService;
        public PatientsPageViewModel(INavigationService service,IPatientMastService patientMastService) : base(service)
        {
            _patientMastService = patientMastService;
        }

        private ObservableCollection<PatientMast> _patientsList = new ObservableCollection<PatientMast>();
        public ObservableCollection<PatientMast> PatientsList
        {
            get
            {
                return _patientsList;
            }
            set
            {
                _patientsList = value; RaisePropertyChanged();
            }
        }

        public async void OnAppearing()
        {
            var result = await _patientMastService.GetAllPatientMastAsync(Utils.UserInfo.CurrentUser.PersonKey);
            if (result != null)
            {
                _patientsList.Clear();
                result.ForEach(pt => PatientsList.Add(pt));
            }
           
        }

    }
}
