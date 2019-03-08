using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeeProject.Classes
{
    class Coffee
    {
        //properties
        private string _coffeeBrand;
        public string GrindType { get; set; }
        public string Origin { get; set; }

        public string roastType { get; set; }

        //public static string
        public string CoffeeBrand
        {
            get { return _coffeeBrand; }
            set { _coffeeBrand = value; }

        }
     
        // default constructor
        public Coffee()
        {
            GrindType = "espresso";
            Origin = "Italy";
            _coffeeBrand = "LaVazza";
        }
        //overloaded constructor taking arguments
        public Coffee (String coffeBrand, string grindType, string origin)
        {
            _coffeeBrand = coffeBrand;
            this.GrindType = grindType;
            this.Origin = origin;
        }
    }
    
}
