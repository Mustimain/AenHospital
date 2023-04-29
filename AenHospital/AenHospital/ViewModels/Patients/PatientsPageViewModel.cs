using AenHospital.Base;
using AenHospital.Models;
using AenHospital.Services.Patient.Interface;
using AenHospital.Views.Patients.PatientDetail;
using Prism.AppModel;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

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
        private PatientMast _selectedPatient;
        public PatientMast SelectedPatient
        {
            get
            {
                return _selectedPatient;
            }
            set
            {
                _selectedPatient = value; RaisePropertyChanged();
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

        public ICommand GoPatientDetailCommand
        {
            get
            {
                return new Command(async () =>
                {
                    if (SelectedPatient != null)
                    {
                        var navParams = new NavigationParameters
                    {
                        {"selectionPatient",SelectedPatient }
                    };
                        await navigationService.NavigateAsync(nameof(PatientDetailNavigationPage), navParams);

                    }

                });
            }
        }

    }
}
