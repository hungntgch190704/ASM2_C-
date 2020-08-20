using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformASM
{
    class Person
    {
        private string name;
        private string phone_num;
        private string email;
        private string address;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public string Number
        {
            get { return phone_num; }
            set { phone_num = value; }
        }

        public string gmail
        {
            get { return email; }
            set { email = value; }
        }
        public string add
        {
            get { return address; }
            set { address = value; }
        }

        public Person(string Name, string Number, string gmail, string add, string book, string sup_food, string sup_water)
        {
            this.Name = Name;
            this.Number = Number;
            this.gmail = gmail;
            this.add = add;
        }
    }
}
