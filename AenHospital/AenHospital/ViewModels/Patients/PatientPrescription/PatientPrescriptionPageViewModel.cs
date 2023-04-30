using AenHospital.Base;
using AenHospital.Models;
using AenHospital.Services.Patient.Interface;
using AenHospital.Views.Patients.PatientAnamesis;
using AenHospital.Views.Patients.PatientPrescription;
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
    public class PatientPrescriptionPageViewModel : BaseViewModel, INavigationAware, IPageLifecycleAware, IInitialize
    {
        private readonly IPatientPrescriptionService _patientPrescriptionService;
        public PatientPrescriptionPageViewModel(INavigationService service, IPatientPrescriptionService patientPrescriptionService) : base(service)
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

        private Models.PatientPrescription _selectedPatientPrescrition;
        public Models.PatientPrescription SelectedPatientPrescrition
        {
            get
            {
                return _selectedPatientPrescrition;
            }
            set
            {
                _selectedPatientPrescrition = value; RaisePropertyChanged();
            }
        }

        private Models.PatientMast _currentPatient;
        public Models.PatientMast CurrentPatient
        {
            get
            {
                return _currentPatient;
            }
            set
            {
                _currentPatient = value; RaisePropertyChanged();
            }
        }

        public async void OnAppearing()
        {
            if (CurrentPatient.pTN != null)
            {
                PatientPrescriptions.Clear();
                var result = await _patientPrescriptionService.GetAllPatientPrescriptionByPtnAsync(CurrentPatient.pTN);

                result.ForEach(prs => PatientPrescriptions.Add(prs));
            }

        }



        public async void Initialize(INavigationParameters parameters)
        {
            var param = parameters.GetValue<PatientMast>("selectionPatient");
            if (parameters.ContainsKey("selectionPatient"))
            {
                CurrentPatient = param;
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

        public ICommand GoPrescriptionDetail
        {
            get
            {
                return new Command(async () =>
                {
                    var navParams = new NavigationParameters
                    {
                        {"SelectionPrescriptionUpdate" , SelectedPatientPrescrition as Models.PatientPrescription }
                    };
                    await navigationService.NavigateAsync(nameof(PatientPrescriptionUpdatePage), navParams);
                });
            }
        }


    }


}
