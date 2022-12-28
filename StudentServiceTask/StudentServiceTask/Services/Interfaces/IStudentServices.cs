using StudentServiceTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServiceTask.Services.Interfaces
{
    internal interface IStudentServices
    {
        public void Create(string name, string surename, double avarage);
        public void Edit(int id, string name, string surename, double avarage);
        public void Delete(int id); 
        public void GetById(int id);
        public Student[] GetAll();
    }
}
