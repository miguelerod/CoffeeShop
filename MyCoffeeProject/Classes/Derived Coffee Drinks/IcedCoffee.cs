using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeeProject.Classes.Derived_Coffee_Drinks
{
    #region Iced Coffee
    class IcedCoffee : CoffeeDrinks
    {
        public string iceAmount { get; set; }

        public IcedCoffee(string size, string brewTime, string iceAmount, double price)
        {
            this.Size = size;
            this.BrewTime = brewTime;
            this.iceAmount = iceAmount;
            this.Price = price;
        }
    }
    #endregion
}
