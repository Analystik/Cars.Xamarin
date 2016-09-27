using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Model
    {
        private Analystik.REST.API _api;

        public Model()
        {
            var context = new Analystik.REST.Context();
            context.BaseUrl = "http://cars101.azurewebsites.net/api/";
            //context.BaseUrl = "http://169.254.164.142/api/";
            this._api = new Analystik.REST.API(context);
        }

        public Task<Data.Make[]> GetMakes()
        {
            return this._api.Get<Data.Make[]>("Makes");

        }
        public Task<Data.Model[]> GetModels(int makeId)
        {
            return this._api.Get<Data.Model[]>($"Makes/{makeId}/models");
        }
        public Task<Data.Car[]> GetCars(int makeId, int modelId)
        {
            return this._api.Get<Data.Car[]>($"makes/{makeId}/models/{modelId}/Cars");
        }

        //public Task<Analystik.REST.IResponse<Data.FinancialEvaluation>> Calculate(Data.Profile profile)
        //{
        //    return this._api.Put<Data.FinancialEvaluation>($"calculate", profile);
        //}


        public Task<Data.Province[]> GetProvinces()
        {
            return this._api.Get<Data.Province[]>("Provinces");
        }

    }
}
