using AenHospital.Base;
using AenHospital.Services.Patient.Interface;
using Prism.AppModel;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AenHospital.ViewModels.Patients.PatientPrescription
{
    public class PatientPrescriptionUpdatePageViewModel : BaseViewModel,INavigatedAware,IPageLifecycleAware
    {

        private readonly IPatientPrescriptionService _patientPrescriptionService;
        private readonly IPageDialogService _pageDialogService;
        private readonly ILogService _logService;
        public PatientPrescriptionUpdatePageViewModel(INavigationService service,IPatientPrescriptionService patientPrescriptionService,IPageDialogService pageDialogService,ILogService logService) : base(service)
        {
            _patientPrescriptionService = patientPrescriptionService;
            _pageDialogService = pageDialogService;
            _logService = logService;
        }

        private Models.PatientPrescription _prescriprionDetail;
        public Models.PatientPrescription PrescriprionDetail
        {
            get
            {
                return _prescriprionDetail;
            }
            set
            {
                _prescriprionDetail = value; RaisePropertyChanged();
            }
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            var navParams = parameters.ContainsKey("SelectionPrescriptionUpdate");
            if (navParams)
            {
                var data = parameters.GetValue<Models.PatientPrescription>("SelectionPrescriptionUpdate");
                PrescriprionDetail = data;
            }
        }

        public ICommand UpdatePrescription
        {
            get
            {
                return new Command(async () =>
                {
                    if (PrescriprionDetail != null)
                    {
                    
                        await _patientPrescriptionService.UpdatePatientPrescription(PrescriprionDetail);
                        await _logService.Log(new Models.T_Log
                        {
                            Keyfield = Utils.UserInfo.SelectionHospital.Keyfield,
                            Log = "Reçete Güncellemesi Yapıldı",
                            LogDate = DateTime.Now,
                            LogTipi = "Güncelleme",
                            UserCode = Utils.UserInfo.CurrentUser.PersonKey.ToString(),


                        });
                        await _pageDialogService.DisplayAlertAsync("Succes", "Güncelleme işlemi başarıyla gerçekleşti","tamam");
                    }
                });
            }
        }

    }
}
