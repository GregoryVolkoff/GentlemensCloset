using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GentlemensCloset
{
    internal class ProductList
    {
        List<Product> products;

        public ProductList()
        {
            products = new List<Product>();

            products = LoadProducts();
        }

        private List<Product> LoadProducts()
        {
            List<Product> products = new List<Product>();

            if (!File.Exists("products.txt"))
            {
                return products;
            }

            try
            {
                StreamReader file = new StreamReader("products.txt");
                int amount = Convert.ToInt32(file.ReadLine());

                for (int i = 0; i < amount; i++)
                {
                    Product p = new Product(file.ReadLine(), file.ReadLine(), Convert.ToInt32(file.ReadLine()), Convert.ToDecimal(file.ReadLine()), file.ReadLine());

                    string separator = file.ReadLine();

                    products.Add(p);
                }
                file.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("Error de lectura!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return products;
        }

        public void SaveProducts()
        {
            try
            {
                StreamWriter file = new StreamWriter("products.txt");
                file.WriteLine(products.Count);
                foreach (Product p in products)
                {
                    file.WriteLine(p.id);
                    file.WriteLine(p.name);
                    file.WriteLine(p.quantity);
                    file.WriteLine(p.price);
                    file.WriteLine(p.category);
                    file.WriteLine();
                }
                file.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("Error de lectura!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public List<Product> GetProducts()
        {
            return products;
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void UpdateCategory(int pos, string id, string name, int quantity, decimal price, string category)
        {
            products[pos].id = id;
            products[pos].name = name;
            products[pos].quantity = quantity;
            products[pos].price = price;
            products[pos].category = category;
        }
    }
}
