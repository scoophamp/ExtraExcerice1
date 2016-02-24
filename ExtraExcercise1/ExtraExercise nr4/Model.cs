using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraExercise_nr4
{
    class Model
    {
        public string Brand { get; set; }
        public string Models { get; set; }

        public void SetModel(string model)
        {
            this.Models = model;
        }

        public void SetBrand(string brand)
        {
            this.Brand = brand;
        }
    }
}
