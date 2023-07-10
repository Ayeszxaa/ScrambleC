using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Menu
{
    public string Flavor { get; set; }
    public string Syrup { get; set; }
    public string Toppings { get; set; }
    public double Price { get; set; }

    public Menu(string flavor, string syrup, string toppings, double price)
    {
        Flavor = flavor;
        Syrup = syrup;
        Toppings = toppings;
        Price = price;
    }
}

