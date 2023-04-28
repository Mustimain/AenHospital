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
            containerRegistry.RegisterInstance( typeof(IAuthService),new AuthService());
            containerRegistry.RegisterInstance(typeof(IHospitalMastService), new HospitalMastService());
            containerRegistry.RegisterInstance(typeof(IPatientAnamesisService), new PatientAnamesisService());
            containerRegistry.RegisterInstance(typeof(IPatientMastService), new PatientMastService());
            containerRegistry.RegisterInstance(typeof(IPatientOrderService), new PatientOrderService());
            containerRegistry.RegisterInstance(typeof(IPatientPrescriptionService), new PatientPrescriptionService());


            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<LoginPage,LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<PatientsPage, PatientsPageViewModel>();

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
