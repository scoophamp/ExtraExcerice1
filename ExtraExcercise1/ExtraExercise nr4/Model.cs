using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraExercise_nr4
{
    class Model
    {
        public string _Brand { get; set; }
        public string _Models { get; set; }

        public void SetModel(string model)
        {
            this._Models = model;
        }

        public void SetBrand(string brand)
        {
            this._Brand = brand;
        }
    }
}
