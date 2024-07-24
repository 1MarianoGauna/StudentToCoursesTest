using CoursesAndStudents.Datos.CQRS.Commands;
using CoursesAndStudents.Model;
using MediatR;

namespace CoursesAndStudents.Datos.CQRS.Querys
{
    public class AddStudentToCourseHandler : IRequestHandler<AddStudentToCourseCommand, StudentToCourse>
    {
        public Task<StudentToCourse> Handle(AddStudentToCourseCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
