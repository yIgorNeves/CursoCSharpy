using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Products.Entities
{
    class UsedProducts : Product
    {
        public DateTime ManufacturedDate { get; set; }

        public UsedProducts ()
        {
        }

        public UsedProducts(string name, double price, DateTime manufacturedDate) : base(name, price)
        {
            ManufacturedDate = manufacturedDate;
        }

        public override string PriceTag()
        {
            return Name
                + " (used) - $" 
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufactured date: "
                + ManufacturedDate.ToString("dd/MM/YYYY")
                + ")";
        }
    }
}
