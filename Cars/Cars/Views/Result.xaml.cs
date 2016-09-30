using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cars.Views
{
    public partial class Result : ContentPage
    {
        private Data.Profile _profile;

        public Result(Data.Profile profile) {
            InitializeComponent();

            this._profile = profile;

            var vm = new Cars.VModel();
            this.BindingContext = vm;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var vm = this.BindingContext as Cars.VModel;
            vm.Evaluate(this._profile);
        }
    }
}
