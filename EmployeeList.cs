using System.IO;
using System.Collections.Generic;
using System;

namespace GentlemensCloset
{
    internal class EmployeeList
    {
        List<Employee> employees;

        public EmployeeList()
        {
            employees = new List<Employee>();

            employees = LoadEmplyees();
        }

        private List<Employee> LoadEmplyees()
        {
            List<Employee> employees = new List<Employee>();

            if (!File.Exists("employees.txt"))
            {
                return employees;
            }
            try
            {
                StreamReader file = new StreamReader("employees.txt");
                int amount = Convert.ToInt32(file.ReadLine());

                for (int i = 0; i < amount; i++)
                {
                    Employee e = new Employee(file.ReadLine(), file.ReadLine(), Convert.ToInt32(file.ReadLine()), file.ReadLine(), file.ReadLine());

                    string separator = file.ReadLine();

                    employees.Add(e);
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

            return employees;
        }
        public void SaveEmployees()
        {
            try
            {
                StreamWriter file = new StreamWriter("employees.txt");
                file.WriteLine(employees.Count);
                foreach (Employee e in employees)
                {
                    file.WriteLine(e.id);
                    file.WriteLine(e.name);
                    file.WriteLine(e.age);
                    file.WriteLine(e.phone);
                    file.WriteLine(e.password);
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

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void UpdateEmployee(int pos, string id, string name, int age, string phone, string password)
        {
            employees[pos].id = id;
            employees[pos].name = name;
            employees[pos].age = age;
            employees[pos].phone = phone;
            employees[pos].password = password;
        }
        public void RemoveEmployee(int index)
        {
            employees.RemoveAt(index);
        }

        public List<string> GetEmployeeName()
        {
            List<string> list = new List<string>();
            foreach (Employee employee in employees)
            {
                list.Add(employee.name);
            }

            return list;
        }

    }
}
