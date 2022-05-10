using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace GentlemensCloset
{
    public partial class CategoryForm : Form
    {
        List<Category> categories;


        public CategoryForm()
        {
            InitializeComponent();
            categories = GetCategories();
            UpdateGrid(categories);
        }

        private List<Category> GetCategories()
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
                    Category c = new Category();
                    c.id = file.ReadLine();
                    c.name = file.ReadLine();
                    c.description = file.ReadLine();
                    string separator = file.ReadLine();
                    categories.Add(c);
                }
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

        private static void SaveCategories(List<Category> categories)
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

        private void button_delete_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_name.Clear();
            textBox_description.Clear();
        }
        private void UpdateGrid(List<Category> categories)
        {
            DataGridView_products.DataSource = typeof(Category);
            DataGridView_products.DataSource = categories;
        }

        private void ClearComboBox()
        {
            textBox_id.Clear();
            textBox_name.Clear();
            textBox_description.Clear();
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            Category c = new Category();

            c.id = textBox_id.Text;
            c.name = textBox_name.Text;
            c.description = textBox_description.Text;

            categories.Add(c);
            UpdateGrid(categories);
            SaveCategories(categories);
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
