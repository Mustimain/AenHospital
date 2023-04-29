using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AenHospital.Views.Patients.PatientDetail
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PatientDetailNavigationPage : TabbedPage
	{
		public PatientDetailNavigationPage ()
		{
			InitializeComponent ();
		}
	}
}