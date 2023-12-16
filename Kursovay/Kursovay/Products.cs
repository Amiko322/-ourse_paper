using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using System.ComponentModel.DataAnnotations;

namespace Kursovay
{
    public class Products
    {
        [Key]
        public int Wrin {  get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Price { get; set; }

        public Products(string name, double weight, int price) 
        { 
            Name = name;
            Weight = weight;
            Price = price;
        }


    }
}
