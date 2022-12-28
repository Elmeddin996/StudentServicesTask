using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentServiceTask.Models
{
    internal class Group
    {
        private static int _id = 0;
        public readonly int Id;
        public string Name;
        public Student[] Students=new Student[0];

        public Group()
        {
            _id++;
            Id = _id;
        }
    }
}
