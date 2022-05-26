using System.Collections.Generic;

namespace DersAtamaApp.Models.Entity
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string HeadOfDepartment { get; set; }
        public List<Student> Students { get; set; }
    }
}
