using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Program
{
    static void Main(string[] args)
    {
       
        Menu chocolateMenu = new Menu("Chocolate", "Vanilla syrup", "Marshmallows", 3.0);
        Menu strawberryMenu = new Menu("Strawberry", "White chocolate syrup ", "sprinkles", 2.5);
        Menu ubeMenu = new Menu("Ube", "White Syrup", "Cheese", 3.5);
        Menu vanillaMenu = new Menu("Vanilla", "Chocolate syrup", "cherry", 2.0);
        Menu melonMenu = new Menu("Melon", "Chocolate syrup", "Stick-O", 1.5);

        Console.WriteLine("Menu Items:");
        Console.WriteLine("1. " + chocolateMenu.Flavor + " - Price: $" + chocolateMenu.Price);
        Console.WriteLine("2. " + strawberryMenu.Flavor + " - Price: $" + strawberryMenu.Price);
        Console.WriteLine("3. " + vanillaMenu.Flavor + " - Price: $" + vanillaMenu.Price);
        Console.WriteLine("4. " + ubeMenu.Flavor + " - Price: $" + ubeMenu.Price);
        Console.WriteLine("5. " + melonMenu.Flavor + " - Price: $" + melonMenu.Price);

        Console.WriteLine("\nEnter the number of the menu item you want to order :");
        int menuChoice = int.Parse(Console.ReadLine());

        Menu selectedMenuItem;
        switch (menuChoice)
        {
            case 1:
                selectedMenuItem = chocolateMenu;
                break;
            case 2:
                selectedMenuItem = strawberryMenu;
                break;
            case 3:
                selectedMenuItem = ubeMenu;
                break;
            case 4:
                selectedMenuItem = vanillaMenu;
                break;
            case 5:
                selectedMenuItem = melonMenu;
                break;
            default:
                Console.WriteLine("Invalid menu choice!");
                return;
        }

        Console.WriteLine("Enter the quantity:");
        int quantity = int.Parse(Console.ReadLine());

        decimal totalPrice = (decimal)selectedMenuItem.Price * quantity;

        Console.WriteLine("\nYour Order is:");
        Console.WriteLine("Menu Item: " + selectedMenuItem.Flavor);
        Console.WriteLine("Flavor: " + selectedMenuItem.Flavor);
        Console.WriteLine("Syrup: " + selectedMenuItem.Syrup);
        Console.WriteLine("Toppings: " + selectedMenuItem.Toppings);
        Console.WriteLine("Quantity: " + quantity);
        Console.WriteLine("Total Price: $" + totalPrice);

        // Wait for user input before closing the program
        Console.WriteLine("\nThankyou for ordering have a nice day ^_^");
        Console.WriteLine("\nPress any key to exit...ammacannaa...");
        Console.ReadKey();
    }
}
