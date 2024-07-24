using CoursesAndStudents.Model;

namespace CoursesAndStudents.Business
{
    public interface IStudentsBusiness
    {
        Task<List<Students>> getAllStudents();
        Task<Students> AddStudent(Students students);
    }
}
