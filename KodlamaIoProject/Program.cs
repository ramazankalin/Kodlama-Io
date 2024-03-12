using KodlamaIoProject.Business;
using KodlamaIoProject.DataAccess.Concretes;
using KodlamaIoProject.Entities;

CourseManager courseManager = new(new CourseDal());
List<Course> courses = courseManager.GetAll();

courseManager.Add(new Course
{
    Id = 3,
    Name = "Test",
    Description = "Test",
    CourseSalary = 15
});
//courseManager.Delete(courses.First());
courseManager.Update(new Course
{
    Id = 4,
    Name = "Test2",
    Description = "Test2",
    CourseSalary = 35
});

for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].CourseSalary);
}

CategoryManager categoryManager = new(new CategoryDal());
List<Category> categories = categoryManager.GetAll();

categoryManager.Add(new Category
{
    Id = 3,
    Name = "Test"
});

//categoryManager.Delete(categories.First());
categoryManager.Update(new Category
{
    Id = 4,
    Name = "Test2"
});

for (int i = 0; i < categories.Count; i++)
{
    Console.WriteLine(categories[i].Name);
}

InstructorManager instructorManager = new(new InstructorDal());
List<Instructor> instructors = instructorManager.GetAll();

instructorManager.Add(new Instructor
{
    Id = 3,
    FirstName = "Ramazan",
    LastName = "Kalin"
});

//instructorManager.Delete(instructors.First());
instructorManager.Update(new Instructor
{
    Id = 4,
    FirstName = "Test2",
    LastName =  "Test"
});

for (int i = 0; i < instructors.Count; i++)
{
    Console.WriteLine(instructors[i].FirstName + " " + instructors[i].LastName);
}
