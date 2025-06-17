using System;

class TeaShop
{
    static void Main(string[] args)
    {
        int totalCost = 0;
        string userChoice;
        bool continueOrdering = true;

        Console.WriteLine("=== Welcome to Suresh Tea Shop ===");

        while (continueOrdering)
        {
            Console.WriteLine("\nSelect your tea:");
            Console.WriteLine("1. Regular Tea - ₹10");
            Console.WriteLine("2. Masala Tea  - ₹15");
            Console.WriteLine("3. Green Tea   - ₹20");
            Console.WriteLine("4. Exit and generate bill");

            Console.Write("Enter your choice (1-4): ");
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    totalCost += 10;
                    Console.WriteLine("Added: Regular Tea - ₹10");
                    break;
                case "2":
                    totalCost += 15;
                    Console.WriteLine("Added: Masala Tea - ₹15");
                    break;
                case "3":
                    totalCost += 20;
                    Console.WriteLine("Added: Green Tea - ₹20");
                    break;
                case "4":
                    continueOrdering = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        Console.WriteLine("\n=== Final Bill ===");
        Console.WriteLine("Total Amount: ₹" + totalCost);
        Console.WriteLine("Thank you for visiting Suresh Tea Shop!");
    }
}