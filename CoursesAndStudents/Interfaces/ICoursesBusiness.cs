using CoursesAndStudents.Model;

namespace CoursesAndStudents.Interfaces
{
    public interface ICoursesBusiness
    {
        Task<List<Courses>> getAllCourses();
        Task<Courses> AddCourse();
    }
}
