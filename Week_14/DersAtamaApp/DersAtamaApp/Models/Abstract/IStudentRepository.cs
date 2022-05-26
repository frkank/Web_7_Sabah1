using DersAtamaApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DersAtamaApp.Models.Abstract
{
    public interface IStudentRepository : IRepository<Student>
    {
        public void GetWithDepartment();
        public Student GetByIdWithCourses(int id);
    }
}
