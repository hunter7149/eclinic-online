using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public  class Employee
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string adress;

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        private string cat;

        public string Cat
        {
            get { return cat; }
            set { cat = value; }
        }
        
        private string sal;

        public string Sal
        {
            get { return sal; }
            set { sal = value; }
        }
    }
}
