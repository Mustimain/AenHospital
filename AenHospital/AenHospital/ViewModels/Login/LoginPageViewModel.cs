using AenHospital.Base;
using AenHospital.Models;
using AenHospital.Services.Auth;
using AenHospital.Services.Patient.Interface;
using AenHospital.Views.Home;
using Prism.AppModel;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AenHospital.ViewModels.Login
{
    public class LoginPageViewModel : BaseViewModel, INavigationAware, IPageLifecycleAware
    {

        private readonly IAuthService _authService;
        private readonly IPageDialogService _pageDialogService;
        private readonly IHospitalMastService _hospitalMastService;
        public LoginPageViewModel(INavigationService service,IAuthService authService,IPageDialogService pageDialogService,IHospitalMastService hospitalMastService) : base(service)
        {
            _authService = authService;
            _pageDialogService = pageDialogService;
            _hospitalMastService = hospitalMastService;
        }

        private ObservableCollection<HospitalMast> _hospitalMasts = new ObservableCollection<HospitalMast>();

        public ObservableCollection<HospitalMast> HospitalMasts
        {
            get
            {
                return _hospitalMasts;
            }
            set
            {
                _hospitalMasts = value; RaisePropertyChanged();
            }
        }

        private HospitalMast _selectedHospitalMast;
        public HospitalMast SelectedHospitalMast
        {
            get { return _selectedHospitalMast; }
            set { _selectedHospitalMast = value; RaisePropertyChanged(); }
        }

        private string _username;
        public string Username
        {
            get { return _username; }
            set { _username = value; RaisePropertyChanged(); }
        }

        

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; RaisePropertyChanged(); }
        }

        private string _rememberMe;
        public string RememberMe
        {
            get { return _rememberMe; }
            set { _rememberMe = value; RaisePropertyChanged(); }
        }

        public async void OnAppearing()
        {
            var hospitalResult = await _hospitalMastService.GetAllHospitalsAsync();
            if (hospitalResult != null)
            {
                _hospitalMasts.Clear();
                hospitalResult.ForEach(hospital => HospitalMasts.Add(hospital));
            }
        }

        [Obsolete]
        public ICommand LoginCommand
        {
            get
            {
                return new Command(async () =>
                {
                  //  _username = "gkoc";
                    //_password = "1453";
                    if (!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password) && SelectedHospitalMast != null)
                    {
                        
                        var result = await _authService.Login(Username, Password);
                        if (result)
                        {
                            Utils.UserInfo.SelectionHospital = SelectedHospitalMast;
                            await navigationService.NavigateAsync(nameof(HomePage));
                        }
                        else
                        {
                            await _pageDialogService.DisplayAlertAsync("Hata", "Girilen bilgilere ait kullanıcı bulunamadı", "tamam");
                        }
                    }
                    else
                    {
                        await _pageDialogService.DisplayAlertAsync("Hata", "Lütfen bilgileri eksiksiz doldurunuz.", "tamam");
                    }

                    

                });
            }
        }



    }
}
