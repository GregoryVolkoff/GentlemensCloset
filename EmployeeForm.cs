using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GentlemensCloset
{
    public partial class EmployeeForm : Form
    {
        EmployeeList employees;

        public EmployeeForm()
        {
            InitializeComponent();
        }
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            employees = new EmployeeList();
            UpdateGrid(employees.GetEmployees());

        }
        private void UpdateGrid(List<Employee> list)
        {
            DataGridView_employees.DataSource = typeof(Employee);
            DataGridView_employees.DataSource = list;
            ChangeGridHeaderText();
        }
        private void ChangeGridHeaderText()
        {
            DataGridView_employees.Columns["id"].HeaderText = "ID";
            DataGridView_employees.Columns["name"].HeaderText = "Nombre";
            DataGridView_employees.Columns["age"].HeaderText = "Edad";
            DataGridView_employees.Columns["phone"].HeaderText = "Teléfono";
            DataGridView_employees.Columns["password"].HeaderText = "Contraseña";
        }
        private void DataGridView_employees_Click(object sender, EventArgs e)
        {
            textBox_id.Text = DataGridView_employees.SelectedRows[0].Cells[0].Value.ToString();
            textBox_name.Text = DataGridView_employees.SelectedRows[0].Cells[1].Value.ToString();
            textBox_age.Text = DataGridView_employees.SelectedRows[0].Cells[2].Value.ToString();
            textBox_phone.Text = DataGridView_employees.SelectedRows[0].Cells[3].Value.ToString();
            textBox_password.Text = DataGridView_employees.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void clear()
        {
            textBox_id.Clear();
            textBox_name.Clear();
            textBox_age.Clear();
            textBox_phone.Clear();
            textBox_password.Clear();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBox_id.Text;
                string name = textBox_name.Text;
                int age = Convert.ToInt32(textBox_age.Text);
                string phone = textBox_phone.Text;
                string password = textBox_password.Text;
                Employee employee = new Employee(id, name, age, phone, password);

                employees.AddEmployee(employee);
                UpdateGrid(employees.GetEmployees());
                employees.SaveEmployees();
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
                if (textBox_id.Text == "" || textBox_name.Text == "" || 
                    textBox_age.Text == "" || textBox_phone.Text == "" || textBox_password.Text == "")
                {
                    MessageBox.Show("Rellena los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int pos = DataGridView_employees.CurrentRow.Index;
                    string id = textBox_id.Text;
                    string name = textBox_name.Text;
                    int age = Convert.ToInt32(textBox_age.Text);
                    string phone = textBox_phone.Text;
                    string password = textBox_password.Text;
                    employees.UpdateEmployee(pos, id, name, age, phone, password);
                    UpdateGrid(employees.GetEmployees());
                    employees.SaveEmployees();
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
            employees.RemoveEmployee(DataGridView_employees.SelectedRows[0].Index);
            UpdateGrid(employees.GetEmployees());
            employees.SaveEmployees();
            clear();
        }

        private void button_products_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
            this.Hide();
        }

        private void button_categories_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
            this.Hide();
        }

        private void button_selling_Click(object sender, EventArgs e)
        {
            SellingForm sellingForm = new SellingForm();
            sellingForm.Show();
            this.Hide();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void exitPicture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
