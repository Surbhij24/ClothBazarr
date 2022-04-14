using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Entity
{
    public class Product : BaseEntity
    {
        public Category Category { get; set; } //creating object to define relation with category
        public Decimal Price { get; set; } // float store approximate value while decimal exact value,
                                           // money - decimal, scientific measurement- float
        //public int Size { get; set; }

    }
}
