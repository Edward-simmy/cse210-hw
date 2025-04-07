using System;

using system.IO;
Public class order
{
    static void Main(string[] args)
     {
        order= new order();

        //Welcome banner
        Console.WriteLine("Welcome Quick Bites!");
        
        bool ordering = true;
        string userInput;
        double itemPrice;
        double itemQuantity;
        double subTol;
        string response;
        
        void pricing()
        {

            Console.Write("MENU OPTIONS 1, 2, 3: ");
            userInput = Console.ReadLine();
            switch (userInput) 
            {
                    case "1":
                itemPrice = 350.00;
                Console.WriteLine("Your order is Fries and a pair of sausages.");
                break;
                    case "2":
                itemPrice = 150.50;
                Console.WriteLine("Your order is Milkshake.");
                break;
                    case "3":
                itemPrice = 200.80;
                Console.WriteLine("Your order is Fries and burger.");
                break;
                default:
                Console.WriteLine("Sorry that is not available at the moment.");
                pricing();
                        break;
                    }
                }
        
                void quantity()
                {
                    Console.Write("Enter quantity: ");
                    itemQuantity = Convert.ToDouble(Console.ReadLine());
                }
        
                void subTotal()
                {
                    subTol = itemQuantity * itemPrice;
                    Console.WriteLine();
                    Console.WriteLine("Your Subtotal: " + subTol);
                }
                        
                while (ordering)
                {    
              Console.WriteLine("What would you like from our menu?");
              Console.WriteLine("\n1. Fries + pair of sausages @(Kes350.00) \n2.A Milkshake (Kes150.50) \n3. Fries + Burger @(200.80)");
              
              
              pricing();
              quantity();
              subTotal();
    
              Console.Write("Please Provide Delivering Location: ")
              response = Console.ReadLine();
              response = response.ToUpper();
    
              
              Console.Write("Would you like anything else? Y/N: ");
              response = Console.ReadLine();
              response = response.ToUpper();
    
    
              if (response == "Y")
              {
                  ordering = true;
              }
              else
              {
                  ordering = false;
                  Console.WriteLine("Thank you for ordering With us ");
                  return $"{order}";
            }
        }
    }
}