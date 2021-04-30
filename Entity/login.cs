using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class login
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string pass;

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        private int role;

        public int Role
        {
            get { return role; }
            set { role = value; }
        }
    }
}
