using DersAtamaApp.Models.Abstract;
using DersAtamaApp.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DersAtamaApp.Models.Concrete.EfCore
{
    public class EfCoreStudentDal : EfCoreGenericDal<Student>, IStudentRepository
    {
        public Student GetByIdWithCourses(int id)
        {
            using (var context = new AppDbContext())
            {
                return context.Students
                    .Where(x => x.StudentId == id)
                    .Include(x => x.StudentCourses)
                    .ThenInclude(x => x.Course)
                    .FirstOrDefault();
            }
        }

        //CRUD metotlarım var.
        public void GetWithDepartment()
        {
            throw new NotImplementedException();
        }
        
    }
}
