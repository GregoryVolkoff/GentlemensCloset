using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GentlemensCloset
{
    internal class CategoryList
    {
        List<Category> categories;

        public CategoryList()
        {
            categories = new List<Category>();

            categories = LoadCategories();
        }
        private List<Category> LoadCategories()
        {
            List<Category> categories = new List<Category>();

            if (!File.Exists("categories.txt"))
            {
                return categories;
            }

            try
            {
                StreamReader file = new StreamReader("categories.txt");
                int amount = Convert.ToInt32(file.ReadLine());

                for (int i = 0; i < amount; i++)
                {
                    Category c = new Category(file.ReadLine(), file.ReadLine(), file.ReadLine());

                    string separator = file.ReadLine();

                    categories.Add(c);
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

            return categories;
        }
        public void SaveCategory()
        {
            try
            {
                StreamWriter file = new StreamWriter("categories.txt");
                file.WriteLine(categories.Count);
                foreach (Category c in categories)
                {
                    file.WriteLine(c.id);
                    file.WriteLine(c.name);
                    file.WriteLine(c.description);
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
        public List<Category> GetCategories()
        {
            return categories;
        }
        public void AddGategory(Category category)
        {
            categories.Add(category);
        }
        public void UpdateCategory(int pos, string id, string name, string description)
        {
            categories[pos].id = id;
            categories[pos].name = name;
            categories[pos].description = description;
        }
        public void RemoveCategory(int index)
        {
            categories.RemoveAt(index);
        }
        public List<string> GetCategoryName()
        {
            List<string> list = new List<string>();
            foreach (Category category in categories)
            {
                list.Add(category.name);
            }

            return list;
        }
    }
}
