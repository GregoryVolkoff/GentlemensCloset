using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GentlemensCloset
{
    internal class Category : IComparable<Category>
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public Category(string id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }

        public int CompareTo(Category other)
        {
            throw new NotImplementedException();
        }
       
    }
}
