using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Interfaces
{
    public interface IPatientRepo
    {
        bool insertDB(patient p);
        int getfee(int n);
        patient getpatient(int n);
        bool insertfee(int n, int m);
        bool updateStatus(patient p);
        List<Doctor> GetAllDoctor(string cat);
        patient getselected(string n);
        bool insertprescribed(patient q, login qw, string s);
        bool DeletePrescribed(patient p);
        List<prescribed> getprescribed(login l);
        
        

        List<patient> GetAllPatient(string id,string w,int i);
    }
}
