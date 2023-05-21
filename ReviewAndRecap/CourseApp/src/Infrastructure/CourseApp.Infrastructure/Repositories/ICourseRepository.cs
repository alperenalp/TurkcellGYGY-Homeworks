using CourseApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Infrastructure.Repositories
{
    public interface ICourseRepository : IRepository<Course>
    {
        public IEnumerable<Course> GetCoursesByCategory(int categoryId);
        public IEnumerable<Course> GetCoursesByName(string name);

    }
}
