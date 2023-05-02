using AenHospital.Base;
using AenHospital.Models;
using AenHospital.Services.Patient.Interface;
using Prism.AppModel;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace AenHospital.ViewModels.Logs
{
    public class LogsPageViewModel : BaseViewModel, IPageLifecycleAware, INavigatedAware, IInitialize
    {

        private readonly ILogService _logService;
        public LogsPageViewModel(INavigationService service, ILogService logService) : base(service)
        {
            _logService = logService;
        }

        private ObservableCollection<Models.T_Log_Detail> _logList = new ObservableCollection<Models.T_Log_Detail>();
        public ObservableCollection<Models.T_Log_Detail> LogList
        {
            get
            {
                return _logList;
            }
            set
            {
                _logList = value; RaisePropertyChanged();
            }
        }


        private DateTime _startDate = DateTime.Now;
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; RaisePropertyChanged(); }
        }

        private DateTime _finishDate = DateTime.Now;
        public DateTime FinishDate
        {
            get { return _finishDate; }
            set { _finishDate = value; RaisePropertyChanged(); }
        }


        public async void Initialize(INavigationParameters parameters)
        {
            _logList.Clear();
            var result = await _logService.GetAllLogsDetail();
            if (result != null)
            {
                result.ForEach(lg => LogList.Add(lg));
            }

        }


        public async void OnAppearing()
        {
            _logList.Clear();
            var result = await _logService.GetAllLogsDetail();
            if (result != null)
            {
                result.ForEach(lg => LogList.Add(lg));
            }

        }

        public ICommand FilterCommand
        {
            get
            {
                return new Command(async () =>
                {
                    if (FinishDate != null && StartDate != null)
                    {
                        var data = await _logService.GetAllLogsDetail();
                        var filterData = data.Where(lg => lg.Log.LogDate >= StartDate && lg.Log.LogDate <= FinishDate).ToList();
                        LogList.Clear();
                        filterData.ForEach(fdata => LogList.Add(fdata));
                    }
                    

                });
            }
        }

        public ICommand CleanListCommand
        {
            get
            {
                return new Command(async () =>
                {
                    _logList.Clear();
                    var result = await _logService.GetAllLogsDetail();
                    if (result != null)
                    {
                        result.ForEach(lg => LogList.Add(lg));
                    }
                });
            }
        }
    }
}