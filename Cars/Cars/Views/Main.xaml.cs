using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Cars.Views
{
	public partial class Main : ContentPage
	{
		public Main ()
		{
			InitializeComponent ();

            var vm = new Cars.VModel();
            this.BindingContext = vm;

            vm.GetProvinces();
            vm.GetMakes();
		}
	}
}
