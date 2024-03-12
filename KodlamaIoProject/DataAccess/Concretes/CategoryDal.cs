using KodlamaIoProject.DataAccess.Abstracts;
using KodlamaIoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoProject.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> categories;
        public CategoryDal()
        {
            Category category = new Category();
            category.Id = 1;
            category.Name = "Programlama";

            Category category2 = new Category();
            category.Id = 2;
            category2.Name = "Tümü";

            categories = new List<Category> { category, category2 };
        }

        public void Add(Category category)
        {
            categories.Add(category);
        }

        public void Delete(Category category)
        {
            categories.Remove(category);
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public void Update(Category category)
        {
            Console.WriteLine("Category is updated!");
        }
    }
}
