using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Cars.Views
{
    public class xItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public xItem(int id, string title)
        {
            this.Id = id;
            this.Title = title;
        }

        public override string ToString()
        {
            return this.Title;
        }


    }


    public partial class Main : ContentPage
    {
        public Main()
        {
            InitializeComponent();

            var vm = new Cars.VModel();
            this.BindingContext = vm;

            vm.PropertyChanged += Vm_PropertyChanged;

            vm.GetProvinces();
            vm.GetMakes();
        }

        private void Vm_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var vm = this.BindingContext as VModel;
            switch (e.PropertyName)
            {
                case "Provinces":
                    this.cboProvince.Items.Clear();
                    foreach (var item in vm.Provinces)
                        this.cboProvince.Items.Add(item.Name);
                    break;
                case "Makes":
                    this.cboBrand.Items.Clear();
                    foreach (var item in vm.Makes)
                        this.cboBrand.Items.Add(item.Name);
                    break;
                default:
                    break;
            }
        }



        //void OnSliderValueChanged(object sender, ValueChangedEventArgs args) {
        //    lblKilometer.Text = ((Slider)sender).Value.ToString("F3");
        //}

        async void OnButtonClicked(object sender, EventArgs args)
        {
            var vm = this.BindingContext as VModel;

            //await DisplayAlert("check", vm.Provinces[this.cboProvince.SelectedIndex].Name, "Cancel");


            //Button button = (Button)sender;
            await Navigation.PushAsync(new Views.Result(new Data.Profile() { CarId = 1, ProvinceId = 1, KMPerYear = 10000 }));
        }
    }
}
