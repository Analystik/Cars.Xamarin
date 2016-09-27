using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Cars.Data
{

    public class NotificationBaseClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaiseNotification(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class Make : NotificationBaseClass
    {
        private int _Id;
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this._Id = value;
                this.RaiseNotification(nameof(Id));
            }
        }

        private string _Name;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                this.RaiseNotification(nameof(Name));
            }
        }
    }

    public class Model : NotificationBaseClass
    {
        private int _Id;
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this._Id = value;
                this.RaiseNotification(nameof(Id));
            }
        }

        private Make _Make;
        public Make Make
        {
            get
            {
                return this._Make;
            }
            set
            {
                this._Make = value;
                this.RaiseNotification(nameof(Make));
            }
        }

        private string _Name;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                this.RaiseNotification(nameof(Name));
            }
        }
    }

    public class Car : NotificationBaseClass
    {
        private int _Id;
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this._Id = value;
                this.RaiseNotification(nameof(Id));
            }
        }

        private Model _Model;
        public Model Model
        {
            get
            {
                return this._Model;
            }
            set
            {
                this._Model = value;
                this.RaiseNotification(nameof(Model));
            }
        }

        private int _Year4Digits;
        public int Year4Digits
        {
            get
            {
                return this._Year4Digits;
            }
            set
            {
                this._Year4Digits = value;
                this.RaiseNotification(nameof(Year4Digits));
            }
        }

        private double _Consumption;
        public double Consumption
        {
            get
            {
                return this._Consumption;
            }
            set
            {
                this._Consumption = value;
                this.RaiseNotification(nameof(Consumption));
            }
        }

        private int _Price;
        public int Price
        {
            get
            {
                return this._Price;
            }
            set
            {
                this._Price = value;
                this.RaiseNotification(nameof(Price));
            }
        }
    }

    public class Province : NotificationBaseClass
    {
        private int _Id;
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this._Id = value;
                this.RaiseNotification(nameof(Id));
            }
        }

        private string _Name;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
                this.RaiseNotification(nameof(Name));
            }
        }

        private double _ElectricityPrice;
        public double ElectricityPrice
        {
            get
            {
                return this._ElectricityPrice;
            }
            set
            {
                this._ElectricityPrice = value;
                this.RaiseNotification(nameof(ElectricityPrice));
            }
        }

        private double _ElectricityPriceGrowthRate;
        public double ElectricityPriceGrowthRate
        {
            get
            {
                return this._ElectricityPriceGrowthRate;
            }
            set
            {
                this._ElectricityPriceGrowthRate = value;
                this.RaiseNotification(nameof(ElectricityPriceGrowthRate));
            }
        }

        private double _GasPrice;
        public double GasPrice
        {
            get
            {
                return this._GasPrice;
            }
            set
            {
                this._GasPrice = value;
                this.RaiseNotification(nameof(GasPrice));
            }
        }

        private double _GasPriceGrowthRate;
        public double GasPriceGrowthRate
        {
            get
            {
                return this._GasPriceGrowthRate;
            }
            set
            {
                this._GasPriceGrowthRate = value;
                this.RaiseNotification(nameof(GasPriceGrowthRate));
            }
        }
    }
    public class Profile : NotificationBaseClass
    {
        private int _CarId;
        public int CarId
        {
            get { return _CarId; }
            set
            {
                this._CarId = value;
                this.RaiseNotification(nameof(CarId));
            }
        }

        private int _KMPerYear;
        public int KMPerYear
        {
            get { return _KMPerYear; }
            set
            {
                this._KMPerYear = value;
                this.RaiseNotification(nameof(KMPerYear));
            }
        }

        private int _ProvinceId;
        public int ProvinceId
        {
            get { return _ProvinceId; }
            set
            {
                this._ProvinceId = value;
                this.RaiseNotification(nameof(ProvinceId));
            }
        }
    }

    public class FinancialEvaluation : NotificationBaseClass
    {
        private double _GasConsumptionIn8Years;
        public double GasConsumptionIn8Years
        {
            get
            {
                return _GasConsumptionIn8Years;
            }
            set
            {
                this._GasConsumptionIn8Years = value;
                this.RaiseNotification(nameof(GasConsumptionIn8Years));
            }
        }

        private double _ElectricityConsumptionIn8Years;
        public double ElectricityConsumptionIn8Years
        {
            get { return _ElectricityConsumptionIn8Years; }
            set
            {
                this._ElectricityConsumptionIn8Years = value;
                this.RaiseNotification(nameof(ElectricityConsumptionIn8Years));
            }
        }

        private double _DeltaPrice;
        public double DeltaPrice
        {
            get { return _DeltaPrice; }
            set
            {
                this._DeltaPrice = value;
                this.RaiseNotification(nameof(DeltaPrice));
            }
        }

        private double _BatteryExpenses;
        public double BatteryExpenses
        {
            get { return _BatteryExpenses; }
            set
            {
                this._BatteryExpenses = value;
                this.RaiseNotification(nameof(BatteryExpenses));
            }
        }

        private double _MileageIn8Years;
        public double MileageIn8Years
        {
            get { return _MileageIn8Years; }
            set
            {
                this._MileageIn8Years = value;
                this.RaiseNotification(nameof(MileageIn8Years));
            }
        }

        private double _GasTotalExpensesPer100km;
        public double GasTotalExpensesPer100km
        {
            get { return _GasTotalExpensesPer100km; }
            set
            {
                this._GasTotalExpensesPer100km = value;
                this.RaiseNotification(nameof(GasTotalExpensesPer100km));
            }
        }

        private double _GasTotalExpensesIn8Years;
        public double GasTotalExpensesIn8Years
        {
            get { return _GasTotalExpensesIn8Years; }
            set
            {
                this._GasTotalExpensesIn8Years = value;
                this.RaiseNotification(nameof(GasTotalExpensesIn8Years));
            }
        }

        private double _ElectricityTotalExpensesPer100km;
        public double ElectricityTotalExpensesPer100km
        {
            get { return _ElectricityTotalExpensesPer100km; }
            set
            {
                this._ElectricityTotalExpensesPer100km = value;
                this.RaiseNotification(nameof(ElectricityTotalExpensesPer100km));
            }
        }

        private double _ElectricityTotalExpensesIn8Years;
        public double ElectricityTotalExpensesIn8Years
        {
            get { return _ElectricityTotalExpensesIn8Years; }
            set
            {
                this._ElectricityTotalExpensesIn8Years = value;
                this.RaiseNotification(nameof(ElectricityTotalExpensesIn8Years));
            }
        }
        private double _ElectricityConsumptionExpensesIn8Years;
        public double ElectricityConsumptionExpensesIn8Years
        {
            get
            {
                return _ElectricityConsumptionExpensesIn8Years;
            }
            set
            {
                this._ElectricityConsumptionExpensesIn8Years = value;
                this.RaiseNotification(nameof(ElectricityConsumptionExpensesIn8Years));
            }
        }
    }
}
