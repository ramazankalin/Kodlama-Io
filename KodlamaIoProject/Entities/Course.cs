using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoProject.Entities
{
    public class Course : Category
    {
        public string Description { get; set; }
        public int CourseSalary { get; set; }
    }
}
