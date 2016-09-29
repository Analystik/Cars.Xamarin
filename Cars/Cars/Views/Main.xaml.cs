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
        public Main()
        {
            InitializeComponent();

            var vm = new Cars.VModel();
            this.BindingContext = vm;

            vm.GetProvinces();
            vm.GetMakes();
        }

        //void OnSliderValueChanged(object sender, ValueChangedEventArgs args) {
        //    lblKilometer.Text = ((Slider)sender).Value.ToString("F3");
        //}

        async void OnButtonClicked(object sender, EventArgs args)
        {
            //Button button = (Button)sender;
            await Navigation.PushAsync(new Views.Result());
        }
    }
}
