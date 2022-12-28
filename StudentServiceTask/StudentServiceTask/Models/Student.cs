using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServiceTask.Models
{
    internal class Student
    {
        private static int _id = 0;
        public readonly int Id;
        public string Name { get; set; }
        public string Surename { get; set; }
        public double Avarage { get; set; }

        public Student()
        {
            _id++;
            Id= _id;
        }
        public override string ToString()
        {
            return $"{Name} {Surename}  {Avarage}";
        }
    }
}
