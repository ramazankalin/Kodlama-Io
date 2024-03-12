using KodlamaIoProject.DataAccess.Abstracts;
using KodlamaIoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoProject.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> instructors;

        public InstructorDal()
        {
            Instructor instructor = new Instructor();
            instructor.Id = 1;
            instructor.FirstName = "Engin";
            instructor.LastName = "Demiroğ";

            Instructor instructor2 = new Instructor();
            instructor2.Id = 2;
            instructor2.FirstName = "Halit Enes";
            instructor2.LastName = "Kalaycı";

            instructors = new List<Instructor> { instructor, instructor2 };
        }
        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            instructors.Remove(instructor);
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Update(Instructor instructor)
        {
            Console.WriteLine("Instructor is updated!");
        }
    }
}
