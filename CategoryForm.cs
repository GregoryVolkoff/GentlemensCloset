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
        CategoryList list;

        public CategoryForm()
        {
            InitializeComponent();
            list = new CategoryList();
            UpdateGrid(list.GetCategories());
        }
       
        private void UpdateGrid(List<Category> list)
        {
            DataGridView_categories.DataSource = typeof(Category);
            DataGridView_categories.DataSource = list;
        }
        
        private void button_add_Click(object sender, EventArgs e)
        {
            Category c = new Category(textBox_id.Text, textBox_name.Text, textBox_description.Text);

            list.AddGategory(c);
            UpdateGrid(list.GetCategories());
            list.SaveCategory();
            clear();
        }

        private void clear()
        {
            textBox_id.Clear();
            textBox_name.Clear();
            textBox_description.Clear();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            list.RemoveCategory(DataGridView_categories.SelectedRows[0].Index);
            UpdateGrid(list.GetCategories());
            list.SaveCategory();
            clear();
        }

        private void DataGridView_categories_Click(object sender, EventArgs e)
        {
            textBox_id.Text = DataGridView_categories.SelectedRows[0].Cells[0].Value.ToString();
            textBox_name.Text = DataGridView_categories.SelectedRows[0].Cells[1].Value.ToString();
            textBox_description.Text = DataGridView_categories.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_id.Text == "" || textBox_name.Text == "" || textBox_description.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int pos = DataGridView_categories.CurrentRow.Index;
                    list.UpdateCategory(pos, textBox_id.Text, textBox_name.Text, textBox_description.Text);
                    UpdateGrid(list.GetCategories());
                    list.SaveCategory();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
