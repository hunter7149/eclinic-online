using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IDoctorRepo
    {
        Doctor getInfo(login l);
        bool insertDoctor(Doctor d);
        bool updateDoctor(Doctor d);
        List<Doctor> getAll();
        Doctor getDoctor(string l);
        bool deleteDoctor(string s);
        List<Complain> getCmp();
        string getName(string s);
        bool insertComplain(string s, string d);
    }
}
