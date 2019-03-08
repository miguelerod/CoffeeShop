using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeeProject.Classes
{
    #region Iced Latte
    class IcedLatte : CoffeeDrinks
    {
        public string IceAmount { get; set; }
        public string MilkAmount { get; set; }

        //public override void calcPrice()  //Not nesseary as the coffee drinks dont need to have different ways to calculate
        //{
        //    RetailPrice = (price * storeFee);
        //}
        public IcedLatte(string size, string brewTime, string IceAmount, string MilkAmount, double price)
        {
            this.Size = size;
            this.BrewTime = brewTime;
            this.IceAmount = IceAmount;
            this.MilkAmount = MilkAmount;
            this.Price = price;
        }
    }
    #endregion
}
