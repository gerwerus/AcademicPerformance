using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicPerformance.Models
{
    internal class Student
    {
        private int[] Marks { get; set; }
        private string Fio { get; set; }

        public Student(int[] marks, string fio)
        {
            Marks = marks;
            Fio = fio;
        }
    }
}
