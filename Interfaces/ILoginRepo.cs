using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Interfaces
{
    public interface ILoginRepo
    {
        login GetUser(string id, string password);
        bool updateUser(login p);
        bool deleteUser(string s);
        bool insertUser(string s, string p, int r);
    }


}
