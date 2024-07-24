using CoursesAndStudents.Interfaces;
using CoursesAndStudents.Model;

namespace CoursesAndStudents.Business
{
    public class CoursesBusiness : ICoursesBusiness
    {
        public ILogger<CoursesBusiness> _logger { get; set; }
        public CoursesBusiness(ILogger<CoursesBusiness> logger)
        {
            _logger = logger;
        }

        public async Task<List<Courses>> getAllCourses()
        {
            throw new NotImplementedException();
        }

        public Task<Courses> AddCourse()
        {

            throw new NotImplementedException();
        }
    }
}
