using Prism.Ioc;
using Prism;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AenHospital.Views;
using AenHospital.ViewModels.Login;
using AenHospital.Services.Auth;
using AenHospital.Services.Patient.Interface;
using AenHospital.Services.Patient.Concrete;
using AenHospital.Views.Home;
using AenHospital.ViewModels.Home;
using AenHospital.Views.Patient;
using AenHospital.ViewModels.Patients;
using AenHospital.Views.Logs;
using AenHospital.ViewModels.Logs;
using AenHospital.Views.Patients.PatientAnamesis;
using AenHospital.ViewModels.Patients.PatientAnamesis;
using AenHospital.Views.Patients.PatientOrder;
using AenHospital.ViewModels.Patients.PatientOrder;
using AenHospital.ViewModels.Patients.PatientPrescription;
using Prism.Mvvm;
using AenHospital.Views.Patients.PatientDetail;
using AenHospital.ViewModels.Patients.PatientDetail;
using AenHospital.Views.Patients.PatientPrescription;

namespace AenHospital
{
    public partial class App
    {
        public App()
        {
            InitializeComponent();
        }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync(nameof(LoginPage));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

            ViewModelLocationProvider.Register<LoginPage,LoginPageViewModel>();
            ViewModelLocationProvider.Register<HomePage, HomePageViewModel>();
            ViewModelLocationProvider.Register<PatientsPage, PatientsPageViewModel>();
            ViewModelLocationProvider.Register<LogsPage, LogsPageViewModel>();
            ViewModelLocationProvider.Register<PatientAnamesisPage, PatientAnamesisPageViewModel>();
            ViewModelLocationProvider.Register<PatientOrderPage, PatientOrderPageViewModel>();
            ViewModelLocationProvider.Register<PatientPrescriptionPage, PatientPrescriptionPageViewModel>();
            ViewModelLocationProvider.Register<PatientPrescriptionUpdatePage, PatientPrescriptionUpdatePageViewModel>();



            containerRegistry.RegisterInstance(typeof(IAuthService),new AuthService());
            containerRegistry.RegisterInstance(typeof(IHospitalMastService), new HospitalMastService());
            containerRegistry.RegisterInstance(typeof(IPatientAnamesisService), new PatientAnamesisService());
            containerRegistry.RegisterInstance(typeof(IPatientMastService), new PatientMastService());
            containerRegistry.RegisterInstance(typeof(IPatientOrderService), new PatientOrderService());
            containerRegistry.RegisterInstance(typeof(IPatientPrescriptionService), new PatientPrescriptionService());
            containerRegistry.RegisterInstance(typeof(ILogService), new LogService(new PatientMastService(),new HospitalMastService()));




            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<PatientDetailNavigationPage>();
            containerRegistry.RegisterForNavigation<LoginPage,LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<PatientsPage, PatientsPageViewModel>();
            containerRegistry.RegisterForNavigation<LogsPage, LogsPageViewModel>();
            containerRegistry.RegisterForNavigation<PatientAnamesisPage, PatientAnamesisPageViewModel>();
            containerRegistry.RegisterForNavigation<PatientOrderPage, PatientOrderPageViewModel>();
            containerRegistry.RegisterForNavigation<PatientPrescriptionPage, PatientPrescriptionPageViewModel>();
            containerRegistry.RegisterForNavigation<PatientPrescriptionUpdatePage, PatientPrescriptionUpdatePageViewModel>();


        }

        protected override void OnStart()
        {
            base.OnStart();
        }

        protected override void OnSleep()
        {
            base.OnSleep();
        }

        protected override void OnResume()
        {
            base.OnResume();
        }
    }
}
