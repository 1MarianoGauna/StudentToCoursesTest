using CoursesAndStudents.Model;
using MediatR;

namespace CoursesAndStudents.Datos.CQRS.Commands
{
    public class GetAllStudentsAndCoursesCommand : IRequest<List<StudentToCourse>>
    {
    }
}
