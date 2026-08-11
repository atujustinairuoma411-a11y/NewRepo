using System;

class Program
{
    static void Main()
    {
        string jewelryName;
        string jewelryType;
        double price;
        double appraisalValue;
        string certification;
        int quantity;

        int count = 1;
        double totalValue = 0;

        Console.WriteLine("====================================");
        Console.WriteLine("       JEWELRY STORE INVENTORY");
        Console.WriteLine("====================================");

        Console.Write("How many jewelry items do you want to enter? ");
        int numberOfItems = Convert.ToInt32(Console.ReadLine());

        while (count <= numberOfItems)
        {
            Console.WriteLine();
            Console.WriteLine("Jewelry Item " + count);
            Console.WriteLine("----------------------------");

            Console.Write("Enter jewelry name: ");
            jewelryName = Console.ReadLine();

            Console.Write("Enter jewelry type (Fine Jewelry / Costume Jewelry): ");
            jewelryType = Console.ReadLine();

            Console.Write("Enter price: ");
            price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter appraisal value: ");
            appraisalValue = Convert.ToDouble(Console.ReadLine());

            Console.Write("Is it certified? (Yes/No): ");
            certification = Console.ReadLine();

            Console.Write("Enter quantity: ");
            quantity = Convert.ToInt32(Console.ReadLine());

            double itemValue = price * quantity;

            totalValue = totalValue + itemValue;

            Console.WriteLine();
            Console.WriteLine("----- Jewelry Details -----");
            Console.WriteLine("Name: " + jewelryName);
            Console.WriteLine("Type: " + jewelryType);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Appraisal Value: " + appraisalValue);
            Console.WriteLine("Certification: " + certification);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Total Item Value: " + itemValue);

            if (jewelryType == "Fine Jewelry")
            {
                Console.WriteLine("Category: High-value jewelry");
            }
            else if (jewelryType == "Costume Jewelry")
            {
                Console.WriteLine("Category: Fashion jewelry");
            }
            else
            {
                Console.WriteLine("Category: Unknown jewelry type");
            }

            if (appraisalValue > price)
            {
                Console.WriteLine("Appraisal Result: Appraisal value is higher than the selling price.");
            }
            else if (appraisalValue == price)
            {
                Console.WriteLine("Appraisal Result: Appraisal value is equal to the selling price.");
            }
            else
            {
                Console.WriteLine("Appraisal Result: Appraisal value is lower than the selling price.");
            }

            count++;
        }

        Console.WriteLine();
        Console.WriteLine("====================================");
        Console.WriteLine("        INVENTORY SUMMARY");
        Console.WriteLine("====================================");
        Console.WriteLine("Number of jewelry items entered: " + numberOfItems);
        Console.WriteLine("Total inventory value: " + totalValue);
        Console.WriteLine("Thank you for using the Jewelry Store Inventory System.");
    }
}