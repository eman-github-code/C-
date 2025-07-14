using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Inventory
{
    private List<Product> products = new List<Product>();
    private const string fileName = "inventory.json";

    public Inventory()
    {
        Load();
    }

    public void AddProduct(Product p)
    {
        products.Add(p);
        Save();
    }

    public void UpdateProduct(int id)
    {
        var p = products.Find(x => x.Id == id);
        if (p == null)
        {
            Console.WriteLine("Product not found.");
            return;
        }

        Console.Write("New Name: ");
        p.Name = Console.ReadLine();
        Console.Write("New Quantity: ");
        p.Quantity = int.Parse(Console.ReadLine());
        Console.Write("New Price: ");
        p.Price = double.Parse(Console.ReadLine());

        Save();
        Console.WriteLine("Product updated.");
    }

    public void DeleteProduct(int id)
    {
        var p = products.Find(x => x.Id == id);
        if (p != null)
        {
            products.Remove(p);
            Save();
            Console.WriteLine("Product deleted.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    public void ListProducts()
    {
        Console.WriteLine("\n📦 Inventory List:");
        foreach (var p in products)
        {
            Console.WriteLine($"ID: {p.Id}, Name: {p.Name}, Qty: {p.Quantity}, Price: ${p.Price:F2}");
        }
    }

    private void Save()
    {
        var json = JsonSerializer.Serialize(products, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(fileName, json);
    }

    private void Load()
    {
        if (File.Exists(fileName))
        {
            var json = File.ReadAllText(fileName);
            products = JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
        }
    }
}
