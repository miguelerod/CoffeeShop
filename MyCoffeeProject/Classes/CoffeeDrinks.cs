using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeeProject.Classes
{
     public abstract class CoffeeDrinks
    {
        public string Size { get; set; }
        public string BrewTime { get; set; }
        public double Price { get; set; }
        protected const double Storefee = .05;

        private double _retailPrice;

        public double RetailPrice
        {
            set
            {
                _retailPrice = value;
                CalcPrice();
            }
            get => _retailPrice;
        }

        //abstract method
        //public abstract void calcPrice();
        public void CalcPrice()
        {
            RetailPrice = (Price * Storefee);
        }

    }
   
    #region Hot Coffee
    class HotCoffee : CoffeeDrinks
    {
  
        public HotCoffee(string siz, string brewTi, double pric)
        {
            Size = siz;
            BrewTime = brewTi;           
            Price = pric;
        }
        //public override void calcPrice()  //Not nesseary as the coffee drinks dont need to have different ways to calculate
        //{
        //    RetailPrice = (price * storeFee);
        //}
    }
    #endregion

    #region Hot Latte
    class HotLatte : CoffeeDrinks
    {
        public string MilkAmount { get; set; }

        public HotLatte(string siz, string brewTi, double pric)
        {
            Size = siz;
            BrewTime = brewTi;
            Price = pric;
        }
    }
    #endregion
}
