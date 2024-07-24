using CoursesAndStudents.Datos.CQRS.Commands;
using CoursesAndStudents.Interfaces;
using CoursesAndStudents.Model;
using Dapper;
using MediatR;

namespace CoursesAndStudents.Datos.CQRS.Querys
{
    public class AddStudentHandler : IRequestHandler<AddStudentCommand, Students>
    {
        public ILogger<AddStudentHandler> _logger;
        private readonly IConnectionDB _db;
        public AddStudentHandler(ILogger<AddStudentHandler> logger, IConnectionDB db)
        {
            _logger = logger;
            _db = db;
        }
        public async Task<Students> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            try
            {
                Guid newId = Guid.NewGuid();

                using (var db = _db.DbConnection())
                {
                    var sql = "INSERT INTO School_Students (ID, FirstName, LastName, Age) VALUES (@ID, @FirstName, @LastName, @Age)";
                    var dbPara = new DynamicParameters();
                    dbPara.Add("@ID", newId);
                    dbPara.Add("@FirstName", request.students.FirstName);
                    dbPara.Add("@LastName", request.students.LastName);
                    dbPara.Add("@Age", request.students.Age);
                    return await db.QueryFirstOrDefaultAsync<Students>(sql, dbPara);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"ERROR EN EL METODO: {ex.Message}");
                throw;
            }
        }
    }
}
