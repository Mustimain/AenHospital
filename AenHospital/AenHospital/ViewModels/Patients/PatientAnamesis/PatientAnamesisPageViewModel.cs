using AenHospital.Base;
using AenHospital.Models;
using Prism.AppModel;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AenHospital.ViewModels.Patients.PatientAnamesis
{
    public class PatientAnamesisPageViewModel : BaseViewModel, INavigationAware, IPageLifecycleAware
    {
        public PatientAnamesisPageViewModel(INavigationService service) : base(service)
        {
        }

        public async void OnAppearing()
        {
        }
    }
}
