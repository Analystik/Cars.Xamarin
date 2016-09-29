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
        private Data.Make SelectedMake;
        private Data.Model SelectedModel;

        private VModel ViewModel { get { return this.BindingContext as VModel; }  }

        public Main()
        {
            InitializeComponent();

            var vm = new Cars.VModel();
            this.BindingContext = vm;

            vm.PropertyChanged += Vm_PropertyChanged;

            this.cboBrand.SelectedIndexChanged += CboBrand_SelectedIndexChanged;
            this.cboModel.SelectedIndexChanged += CboModel_SelectedIndexChanged;

            vm.GetProvinces();
            vm.GetMakes();
        }


        private void CboBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedMake = null;
            var index = this.cboBrand.SelectedIndex;

            if (index > -1)
                this.SelectedMake = this.ViewModel.Makes[index] as Data.Make;


            this.ViewModel.GetModels(this.SelectedMake?.Id ?? 0);
        }

        private void CboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedModel = null;
            var index = this.cboModel.SelectedIndex;

            if (index > -1)
                this.SelectedModel = this.ViewModel.Models[index] as Data.Model;

            this.ViewModel.GetCars(this.SelectedMake?.Id ?? 0, this.SelectedModel?.Id ?? 0);
        }

        private void Vm_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            
            switch (e.PropertyName)
            {
                case "Makes":
                    this.cboBrand.Items.Clear();
                    foreach (var item in this.ViewModel.Makes)
                        this.cboBrand.Items.Add(item.Name);
                    break;
                case "Models":
                    this.cboModel.Items.Clear();
                    foreach (var item in this.ViewModel.Models)
                        this.cboModel.Items.Add(item.Name);
                    break;
                case "Cars":
                    this.cboCar.Items.Clear();
                    foreach (var item in this.ViewModel.Cars)
                        this.cboCar.Items.Add(item.Year4Digits.ToString());
                    break;
                case "Provinces":
                    this.cboProvince.Items.Clear();
                    foreach (var item in this.ViewModel.Provinces)
                        this.cboProvince.Items.Add(item.Name);
                    break;
                default:
                    break;
            }
        }


        async void OnButtonClicked(object sender, EventArgs args)
        {
            var car = this.ViewModel.Cars[this.cboCar.SelectedIndex] as Data.Car;
            var province = this.ViewModel.Provinces[this.cboProvince.SelectedIndex] as Data.Province;

            var profile = new Data.Profile();
            profile.CarId = car?.Id ?? 0;
            profile.KMPerYear = Convert.ToInt32(this.sldKilometer.Value);
            profile.ProvinceId = province?.Id ?? 0;

            await Navigation.PushAsync(new Views.Result(profile));
        }
    }
}
