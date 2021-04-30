using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Complain
    {
        string cmp;
        string date;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Cmp
        {
            get { return cmp; }
            set { cmp = value; }
        }
    }
}
