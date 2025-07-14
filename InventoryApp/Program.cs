using System;

class Program
{
    static Inventory inventory = new Inventory();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Inventory Menu ===");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. List Products");
            Console.WriteLine("3. Update Product");
            Console.WriteLine("4. Delete Product");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddProduct();
                    break;
                case "2":
                    inventory.ListProducts();
                    break;
                case "3":
                    UpdateProduct();
                    break;
                case "4":
                    DeleteProduct();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    static void AddProduct()
    {
        var p = new Product();

        Console.Write("ID: ");
        p.Id = int.Parse(Console.ReadLine());
        Console.Write("Name: ");
        p.Name = Console.ReadLine();
        Console.Write("Quantity: ");
        p.Quantity = int.Parse(Console.ReadLine());
        Console.Write("Price: ");
        p.Price = double.Parse(Console.ReadLine());

        inventory.AddProduct(p);
        Console.WriteLine("Product added.");
    }

    static void UpdateProduct()
    {
        Console.Write("Enter Product ID to update: ");
        int id = int.Parse(Console.ReadLine());
        inventory.UpdateProduct(id);
    }

    static void DeleteProduct()
    {
        Console.Write("Enter Product ID to delete: ");
        int id = int.Parse(Console.ReadLine());
        inventory.DeleteProduct(id);
    }
}
