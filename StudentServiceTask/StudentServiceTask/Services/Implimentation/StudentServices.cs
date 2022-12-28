using StudentServiceTask.Models;
using StudentServiceTask.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServiceTask.Services.Implimentation
{
    internal class StudentServices : IStudentServices
    {
        Group group = new Group();
        public void Create(string name, string surename, double avarage)
        {
            Student student = new Student
            {
                Name = name,
                Surename = surename,
                Avarage = avarage
            };
            Array.Resize(ref group.Students, group.Students.Length + 1);
            group.Students[group.Students.Length - 1] = student;
        }

        public void Delete(int id)
        {
            for (int i = 0; i < group.Students.Length; i++)
            {
                if (group.Students[i].Id == id)
                {
                    group.Students[i] = group.Students[group.Students.Length - 1];
                    Array.Resize(ref group.Students, group.Students.Length - 1);
                    return;
                }



            }
            Console.WriteLine("Daxil Etdiyiniz Id-de Telebe Yoxdur");



        }

        public void Edit(int id, string name, string surename, double avarage)
        {
            for (int i = 0; i < group.Students.Length; i++)
            {
                if (group.Students[i].Id == id)
                {
                    group.Students[i].Name = name;
                    group.Students[i].Surename = surename;
                    group.Students[i].Avarage = avarage;
                    return;
                }

            }
            Console.WriteLine("Daxil Etdiyiniz Id-de Telebe Yoxdur");

        }

        public Student[] GetAll()
        {
            return group.Students;
        }

        public void GetById(int id)
        {
            for (int i = 0; i < group.Students.Length; i++)
            {
                if (group.Students[i].Id == id)
                {
                    Console.WriteLine($"{group.Students[i].Name}  {group.Students[i].Surename}");
                    return;
                }
              
            }
            Console.WriteLine("Daxil Etdiyiniz Id-de Telebe Yoxdur");
         
        }

    }
}