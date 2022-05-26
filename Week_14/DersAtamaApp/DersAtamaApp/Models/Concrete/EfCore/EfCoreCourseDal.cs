using DersAtamaApp.Models.Abstract;
using DersAtamaApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DersAtamaApp.Models.Concrete.EfCore
{
    public class EfCoreCourseDal : EfCoreGenericDal<Course>,ICourseRepository
    {
    }
}
