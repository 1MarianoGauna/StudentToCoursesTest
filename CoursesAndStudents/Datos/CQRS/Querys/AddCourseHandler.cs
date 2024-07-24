using CoursesAndStudents.Datos.CQRS.Commands;
using CoursesAndStudents.Interfaces;
using CoursesAndStudents.Model;
using Dapper;
using MediatR;
using System.Data.Common;

namespace CoursesAndStudents.Datos.CQRS.Querys
{
    public class AddCourseHandler : IRequestHandler<AddCourseCommand, Courses>
    {
        private ILogger<AddCourseHandler> _logger;
        private IConnectionDB _db;
        public AddCourseHandler(ILogger<AddCourseHandler> logger, IConnectionDB db)
        {
            _logger = logger;
            _db = db;
        }

        public async Task<Courses> Handle(AddCourseCommand request, CancellationToken cancellationToken)
        {
            Guid newId = Guid.NewGuid();
            try
            {
                using(var db = _db.DbConnection())
                {
                    var sql = "INSERT INTO School_Courses (ID, Amount, StartDate, EndDate) VALUES (@ID, @Amount, @StartDate, @EndDate)";
                    var dbPara = new DynamicParameters();
                    dbPara.Add("@ID", newId);
                    dbPara.Add("@Amount", request.Amount);
                    dbPara.Add("@StartDate", request.StartDate);
                    dbPara.Add("@EndDate", request.EndDate);
                    return await db.QueryFirstOrDefaultAsync<Courses>(sql, dbPara);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"ERROR EN EL METODO:{ex.Message}");
                throw;
            }
        }
    }
}
