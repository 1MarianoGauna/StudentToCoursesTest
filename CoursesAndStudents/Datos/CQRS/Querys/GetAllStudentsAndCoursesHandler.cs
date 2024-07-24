using CoursesAndStudents.Datos.CQRS.Commands;
using CoursesAndStudents.Interfaces;
using CoursesAndStudents.Model;
using Dapper;
using MediatR;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace CoursesAndStudents.Datos.CQRS.Querys
{
    public class GetAllStudentsAndCoursesHandler : IRequestHandler<GetAllStudentsAndCoursesCommand, List<StudentToCourse>>
    {

        private readonly IMediator _mediator;
        private readonly IConnectionDB _db;
        public GetAllStudentsAndCoursesHandler(IMediator mediator, IConnectionDB db)
        {
            _mediator = mediator;
            _db = db;
        }

        public async Task<List<StudentToCourse>> Handle(GetAllStudentsAndCoursesCommand request, CancellationToken cancellationToken)
        {
            List<StudentToCourse> courses = new List<StudentToCourse>(); 
            try
            {
                using (var db = _db.DbConnection())
                {
                    var sql = "Select ID, Name From School_Courses";
                    courses = (await db.QueryAsync<StudentToCourse>(sql)).ToList();
                    return courses;
                }
                return courses;
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
