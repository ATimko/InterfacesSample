using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesSample
{
    class Product : IDisplayable, IComparable<Product>
    {
	    public string Name { get; set; }

        public double Price { get; set; }

        public string GetDisplayText()
        {
            return Name + " " + Price;
        }

        //We will sort by price
        int IComparable<Product>.CompareTo(Product other)
        {
            if (other == null)
                return 1;

            //sort by price
            return this.Price.CompareTo(other.Price);
            // If this curr instance comes before "other"
            // Return less than Zero (-1)
            if (this.Price < other.Price)
                return -1;

            //Return 0 if "this" and "other" are in
            // the same position
            else if (this.Price == other.Price)
                return 0;

            //Return greater than 0 (1) if "this follows"
            //"other"
            else (this.Price > other.Price)
                return 1;
        }
    }
}
