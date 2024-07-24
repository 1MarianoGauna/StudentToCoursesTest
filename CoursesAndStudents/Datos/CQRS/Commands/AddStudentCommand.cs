using CoursesAndStudents.Model;
using MediatR;

namespace CoursesAndStudents.Datos.CQRS.Commands
{
    public class AddStudentCommand : IRequest<Students>
    {
        public Students students { get; set; }
    }
}
