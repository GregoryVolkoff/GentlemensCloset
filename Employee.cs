using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GentlemensCloset
{
    internal class Employee
    {
        public string id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string phone { get; set; }
        public string password { get; set; }

        public Employee(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public Employee(string id, string name, int age, string phone, string password)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.phone = phone;
            this.password = password;
        }

        public override bool Equals(object obj)
        {
            return obj is Employee employee &&
                   name == employee.name &&
                   password == employee.password;
        }
    }
}
