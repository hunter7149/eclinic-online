using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class prescribed
    {
        string did;
        string name;
        string phone;
        string comment;
        string pres;
        string bgroup;
        string date;
        int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Bgroup
        {
            get { return bgroup; }
            set { bgroup = value; }
        }

        public string Pres
        {
            get { return pres; }
            set { pres = value; }
        }

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Did
        {
            get { return did; }
            set { did = value; }
        }
    }
}
