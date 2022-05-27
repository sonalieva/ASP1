using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Exam
    {
        public Exam(int id, string name, int point)
        {
            this.Id = id;
            this.StudentFullName = name;
            this.Point = point;
        }
        public int Id { get; set; }
        public string StudentFullName { get; set; }
        public int Point { get; set; }
    }

}

