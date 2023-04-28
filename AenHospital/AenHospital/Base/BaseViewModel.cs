using Prism.AppModel;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AenHospital.Base
{
    public class BaseViewModel : BindableBase, IInitialize, INavigationAware, IDestructible, IPageLifecycleAware
    {
        protected INavigationService navigationService { get; set; }

        private bool _IsBusy;

        public bool IsBusy
        {
            get { return _IsBusy; }
            set { _IsBusy = value; RaisePropertyChanged(); }
        }
        public BaseViewModel(INavigationService service)
        {
            navigationService = service;
        }

        public void Destroy()
        {

        }

        public void Initialize(INavigationParameters parameters)
        {

        }

        public void OnAppearing()
        {
        }

        public void OnDisappearing()
        {

        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {

        }
    }
}
