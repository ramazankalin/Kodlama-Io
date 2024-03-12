using KodlamaIoProject.DataAccess.Abstracts;
using KodlamaIoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoProject.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> courses;

        public CourseDal()
        {
            Course course = new Course();
            course.Id = 1;
            course.Name = "C#";
            course.Description = "2024 Yazılım Geliştirici Yetiştirme Kampı";
            course.CourseSalary = 0;

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "Java";
            course2.Description = "2024 Yazılım Geliştirici Yetiştirme Kampı-2";
            course2.CourseSalary = 0;

            courses = new List<Course> { course, course2 };

        }
        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Delete(Course course)
        {
            courses.Remove(course);
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public void Update(Course course)
        {
            Console.WriteLine("Course is updated!");
        }
    }
}
