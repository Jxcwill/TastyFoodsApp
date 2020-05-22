using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tastyfoodlib
{
   public class FoodItems
    {
        public FoodItems()
        {
            this.items = new List<string[]>();
        }
        public string[] Name { get; set; }
        public double[] Price { get; set; }
        public string[] Description { get; set; }
        public int[] AmountInStock { get; set; }

        public List<string[]> items { get; set; }
    }
}
