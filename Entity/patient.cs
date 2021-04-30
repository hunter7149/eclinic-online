using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class patient
    {
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
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private string bgroup;

        public string Bgroup
        {
            get { return bgroup; }
            set { bgroup = value; }
        }
        private string date;
        private string cat;


        public string Cat
        {
            get { return cat; }
            set { cat = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        private string did;

        public string Did
        {
            get { return did; }
            set { did = value; }
        }
        private int refer;

        public int Refer
        {
            get { return refer; }
            set { refer = value; }
        }

        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}