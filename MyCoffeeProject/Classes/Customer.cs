using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoffeeProject.Classes
{
    class Customer
    {
        //Instance variables. You reference with THIS. Values change with different customer objects. 
       
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        //public string favCoffee { get; set; }
        //test
        private string _favCoffee;

        public string FavCoffee
        {
            get
            {
                return _favCoffee;
            }

            set
            {
                _favCoffee = value;
            }
        }

        //another way to set/ get
        private string phoneNumber;
        public string PhoneNumber
        {
            set { phoneNumber = value; }
            get { return phoneNumber; }
        }

      


        //Private varible becasue want to prevent - customer # being set
        private int _custId;

        //set
        public void setId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("ID cant be negative number");
            }
            //set
            this._custId = id;
        }

        //get
        public int getId()
        {
            return this._custId;
        }

        private int _test;

        //can right click on private field and chose encapluate. THis will automatically make get and set for you.

       
        //static varible.  //Doesn’t change value ever. Don’t refer to it, using this. You use the class name.
        //You save a lot of memory using static when creating many objects, bec you refernce same object in memory.
        //public static double FEE = .3;
        //Constants are fine and preverable. Very detailed answer here:
        public const double FEE = .3;

        //Default constructor defining values

        //public Customer ()
        //{
        //    //FirstName = "Nick";
        //    //Lastname = "Brooks";
        //    //favCoffee = "Peet's";
        //    //PhoneNumber = "111-1111";
        //}

        //constructor taking arguments
        public Customer( string firstName, string L,  string phone, string fCoffee)
        {
            FirstName = firstName;
            Lastname = L;
            FavCoffee = fCoffee;
            PhoneNumber = phone;
        }
        public string DisplayCustomer()
        {
            return FirstName + " " + Lastname + " " + " Phone Number: " + phoneNumber + Environment.NewLine + "Favorite Coffee: " + this._favCoffee;
        }
        public string GetFullName()
        {
            return this.FirstName + " " + this.Lastname;
        }
        public double getFee()
        {
            return FEE;
        }
    }
}
