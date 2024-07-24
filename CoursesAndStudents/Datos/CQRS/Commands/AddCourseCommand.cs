using CoursesAndStudents.Model;
using MediatR;

namespace CoursesAndStudents.Datos.CQRS.Commands
{
    public class AddCourseCommand : IRequest<Courses>
    {
        public string Course { get; set; }

        public int Amount { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

    }
}
