using ClassificacaoProduto.Entities;
using System;
using System.Collections.Generic;

namespace ClassificacaoProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int price;
            double customs;
            DateTime manufacture;
            char ch;
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int product = int.Parse(Console.ReadLine());

            for (int i = 1; i <= product; i++)
            {
                Console.Clear();
                Console.WriteLine($"Product: {i}");
                Console.WriteLine();
                Console.Write("Common, Used or Imported (c/u/i)? ");
                ch = char.Parse(Console.ReadLine());
                if (ch == 'c')
                {
                    Console.Write("Name: ");
                     name = Console.ReadLine();
                    Console.Write("Price: ");
                     price = int.Parse(Console.ReadLine());

                    products.Add(new Product(name, price));
                }else if (ch =='u')
                {
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Price: ");
                    price = int.Parse(Console.ReadLine());
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    manufacture = DateTime.Parse(Console.ReadLine());


                    products.Add(new UsedProduct(name, price, manufacture));

                }else if(ch == 'i')
                {
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Price: ");
                    price = int.Parse(Console.ReadLine());
                    Console.Write("Customs fee: ");
                    customs = double.Parse(Console.ReadLine());

                    products.Add(new ImportedProduct(name,price,customs));
                }
            }
            Console.WriteLine();
            foreach (Product item in products)
            {
                Console.WriteLine(item.PriceTag());
                Console.WriteLine();

            }
        }
    }
}
