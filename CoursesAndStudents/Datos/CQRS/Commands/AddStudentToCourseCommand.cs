using CoursesAndStudents.Model;
using MediatR;

namespace CoursesAndStudents.Datos.CQRS.Commands
{
    public class AddStudentToCourseCommand : IRequest<StudentToCourse>
    {
        public StudentToCourse studentToCourse { get; set; }
    }
}
