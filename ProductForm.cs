using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GentlemensCloset
{
    public partial class ProductForm : Form
    {
        CategoryList categoryList;
        ProductList productList;
        public ProductForm()
        {
            InitializeComponent();
           
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            categoryList = new CategoryList();
            productList = new ProductList();
            LoadComboBox(categoryList);
            UpdateGrid(productList.GetProducts());
        }

        private void UpdateGrid(List<Product> list)
        {
            DataGridView_products.DataSource = typeof(Product);
            DataGridView_products.DataSource = list;
            ChangeGridHeaderText();
        }
        private void LoadComboBox(CategoryList categoryList)
        {
            comboBox_category.DataSource = categoryList.GetCategoryName();
            comboBox_refresh.DataSource = categoryList.GetCategoryName();
        }
        private void DataGridView_products_Click(object sender, EventArgs e)
        {
            textBox_id.Text = DataGridView_products.SelectedRows[0].Cells[0].Value.ToString();
            textBox_name.Text = DataGridView_products.SelectedRows[0].Cells[1].Value.ToString();
            textBox_quantity.Text = DataGridView_products.SelectedRows[0].Cells[2].Value.ToString();
            textBox_price.Text = DataGridView_products.SelectedRows[0].Cells[3].Value.ToString();
            comboBox_category.Text = DataGridView_products.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void clear()
        {
            textBox_id.Clear();
            textBox_name.Clear();
            textBox_price.Clear();
            textBox_quantity.Clear();
            comboBox_category.SelectedIndex = 0;
        }
        private void ChangeGridHeaderText()
        {
            DataGridView_products.Columns["id"].HeaderText = "ID";
            DataGridView_products.Columns["name"].HeaderText = "Nombre";
            DataGridView_products.Columns["quantity"].HeaderText = "Cantidad";
            DataGridView_products.Columns["price"].HeaderText = "Precio";
            DataGridView_products.Columns["category"].HeaderText = "Categoría";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBox_id.Text;
                string name = textBox_name.Text;
                decimal price = Convert.ToDecimal(textBox_price.Text);
                int quantity = Convert.ToInt32(textBox_quantity.Text);
                string category = comboBox_category.Text;
                Product product = new Product(id, name, quantity, price, category);

                productList.AddProduct(product);
                UpdateGrid(productList.GetProducts());
                productList.SaveProducts();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_id.Text == "" || textBox_name.Text == "" || textBox_quantity.Text == "" || textBox_price.Text == "")
                {
                    MessageBox.Show("Rellena los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int pos = DataGridView_products.CurrentRow.Index;
                    string id = textBox_id.Text;
                    string name = textBox_name.Text;
                    int quantity = Convert.ToInt32(textBox_quantity.Text);
                    decimal price = Convert.ToDecimal(textBox_price.Text);
                    string category = comboBox_category.Text;
                    productList.UpdateProduct(pos, id, name, quantity, price, category);
                    UpdateGrid(productList.GetProducts());
                    productList.SaveProducts();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            productList.RemoveProduct(DataGridView_products.SelectedRows[0].Index);
            UpdateGrid(productList.GetProducts());
            productList.SaveProducts();
            clear();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            UpdateGrid(productList.GetProducts());
        }

        private void comboBox_refresh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataGridView_products.DataSource = productList.GetProductsByCategory(comboBox_refresh.SelectedValue.ToString());
        }

        private void exitPicture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_category_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void button_employees_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
            this.Hide();
        }

        private void button_selling_Click(object sender, EventArgs e)
        {
            SellingForm sellingForm = new SellingForm();
            sellingForm.Show();
            this.Hide();
        }
    }
}
