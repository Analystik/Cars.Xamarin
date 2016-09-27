using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace Cars
{
    public class VModel : Notificationbase
    {
        private Model _Model = new Model();


        #region ** MAKES **

        private ObservableCollection<Data.Make> _Makes;
        public ObservableCollection<Data.Make> Makes
        {
            get { return this._Makes; }
            set { this._Makes = value; this.RaiseNotification(nameof(Makes)); }
        }

        public async void GetMakes()
        {
            var data = await this._Model.GetMakes();
            this.Makes = new ObservableCollection<Data.Make>(data);

        }

        #endregion


        #region ** MODELS **

        private ObservableCollection<Data.Model> _Models;
        public ObservableCollection<Data.Model> Models
        {
            get { return this._Models; }
            set { this._Models = value; this.RaiseNotification(nameof(Models)); }
        }

        public async void GetModels(int makeId)
        {
            var data = await this._Model.GetModels(makeId);
            this.Models = new ObservableCollection<Data.Model>(data);

        }

        #endregion


        #region ** CARS **

        private ObservableCollection<Data.Car> _Cars;
        public ObservableCollection<Data.Car> Cars
        {
            get { return this._Cars; }
            set { this._Cars = value; this.RaiseNotification(nameof(Cars)); }
        }


        public async void GetCars(int makeId, int modelId)
        {
            var data = await this._Model.GetCars(makeId, modelId);
            this.Cars = new ObservableCollection<Data.Car>(data);
        }

        #endregion


        #region ** PROVINCE **

        private ObservableCollection<Data.Province> _Provinces;

        public ObservableCollection<Data.Province> Provinces
        {
            get { return this._Provinces; }
            set { this._Provinces = value; this.RaiseNotification(nameof(Provinces)); }
        }

        public async void GetProvinces()
        {
            var data = await this._Model.GetProvinces();
            this.Provinces = new ObservableCollection<Data.Province>(data);

        }

        #endregion


//        #region ** EVAL **

//        private Data.FinancialEvaluation _FinEvaluation;
//        public Data.FinancialEvaluation FinEvaluation
//        {
//            get { return this._FinEvaluation; }
//            set
//            {
//                this._FinEvaluation = value;
//                this.RaiseNotification(nameof(FinEvaluation));
//                this.RaiseNotification(nameof(FinEvaluationDescription));
//            }
//        }

//        public string FinEvaluationDescription
//        {
//            get
//            {

//                string msg = "";
//                if (this.FinEvaluation != null)
//                {
//                    msg = $@"Vous allez dépenser {this.FinEvaluation.GasConsumptionIn8Years:N2}$ en essence

//Vous allez dépenser {this.FinEvaluation.ElectricityConsumptionExpensesIn8Years:N2}$ en électricité

//Vous aurez dépensé {this.FinEvaluation.DeltaPrice:N2}$ de plus en achetant une voiture électrique

//Le coût estimé pour le remplacement de la batterie est {this.FinEvaluation.BatteryExpenses:N2}$.
//";
//                }

//                return msg;
//            }
//        }

//        public async void Evaluate(Data.Profile profile)
//        {
//            var data = await this._Model.Calculate(profile);
//            this.FinEvaluation = data.Content;
//        }

//        #endregion

    }
}
