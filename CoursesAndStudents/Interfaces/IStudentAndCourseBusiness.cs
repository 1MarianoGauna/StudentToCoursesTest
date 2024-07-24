using CoursesAndStudents.Model;

namespace CoursesAndStudents.Interfaces
{
    public interface IStudentAndCourseBusiness
    {
        Task<List<StudentToCourse>> getAllStudentsAndCourse();
        Task<StudentToCourse> AddStudentToCourse(StudentToCourse info);
    }
}
