using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace GentlemensCloset
{
    public partial class SellingForm : Form
    {
        decimal totalAmount = 0, n = 0;

        BillList billList;
        CategoryList categoryList;
        ProductList productList;
        DGVPrinter printer;

        string role;
        public SellingForm()
        {
            InitializeComponent();
        }
        public SellingForm(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            if (role == "EMPLEADO")
            {
                button_categories.Hide();
                button_employees.Hide();
                button_productos.Hide();

                pictureBox_user.Image = global::GentlemensCloset.Properties.Resources.user_100px;
            }

            label_date.Text = DateTime.Today.ToShortDateString();
            label_username.Text = FormLogin.employeeName;

            categoryList = new CategoryList();
            productList = new ProductList();
            billList = new BillList();
            printer = new DGVPrinter();
            LoadComboBox();
            GetProducts();
            GetBills();

        }

        private void LoadComboBox()
        {
            comboBox_products.DataSource = categoryList.GetCategoryName();
        }

        private void GetProducts()
        {
            dataGridView_products.DataSource = productList.GetProducts();
            dataGridView_products.Columns[0].Visible = false;
            dataGridView_products.Columns[2].Visible = false;
            dataGridView_products.Columns[4].Visible = false;

        }

        private void GetBills()
        {
            dataGridView_bills.DataSource = typeof(Bill);
            dataGridView_bills.DataSource = billList.GetBills();
        }
        private void dataGridView_products_Click(object sender, EventArgs e)
        {
            textBox_name.Text = dataGridView_products.SelectedRows[0].Cells[1].Value.ToString();
            textBox_price.Text = dataGridView_products.SelectedRows[0].Cells[3].Value.ToString();
        }


        private void button_addId_Click(object sender, EventArgs e)
        {
            try
            {
                Bill bill = new Bill(textBox_IDbill.Text, label_username.Text, DateTime.Now, totalAmount);

                billList.AddBill(bill);
                GetBills();
                billList.SaveBills();
                textBox_IDbill.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_addOrder_Click(object sender, EventArgs e)
        {
            if (textBox_price.Text == "" || textBox_quantity.Text == "")
            {
                MessageBox.Show("Missing Information", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                decimal Total = Convert.ToDecimal(textBox_price.Text) * Convert.ToInt32(textBox_quantity.Text);
                DataGridViewRow addRow = new DataGridViewRow();
                addRow.CreateCells(dataGridView_orderList);
                addRow.Cells[0].Value = ++n;
                addRow.Cells[1].Value = textBox_name.Text;
                addRow.Cells[2].Value = textBox_price.Text;
                addRow.Cells[3].Value = textBox_quantity.Text;
                addRow.Cells[4].Value = Total;
                dataGridView_orderList.Rows.Add(addRow);
                totalAmount += Total;
                label_currency.Text = totalAmount + " €";
            }
        }
        private void button_print_Click(object sender, EventArgs e)
        {
            printer.Title = "Gentlemen Closet bills";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("d"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGridView_bills);
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            GetProducts();
        }

        private void button_employees_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
            this.Hide();
        }

        private void button_categories_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
            this.Hide();
        }

        private void button_productos_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
            this.Hide();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void comboBox_products_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataGridView_products.DataSource = productList.GetProductsByCategory(comboBox_products.SelectedValue.ToString());
            dataGridView_products.Columns[0].Visible = false;
            dataGridView_products.Columns[2].Visible = false;
            dataGridView_products.Columns[4].Visible = false;
        }

        private void exitPicture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
