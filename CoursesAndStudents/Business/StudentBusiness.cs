using CoursesAndStudents.Interfaces;
using CoursesAndStudents.Model;
using CoursesAndStudents.Datos;
using MediatR;
using CoursesAndStudents.Datos.CQRS.Commands;

namespace CoursesAndStudents.Business
{
    public class StudentBusiness : IStudentsBusiness
    {

        private readonly ILogger<StudentBusiness> _logger;
        private readonly IMediator _mediator;
        public StudentBusiness(ILogger<StudentBusiness> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public async Task<Students> AddStudent(Students info)
        {
            try
            {

                if(info != null)
                {
                    info = await _mediator.Send(new AddStudentCommand { students = info});
                    return info;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error en el metodo: {ex.Message}");
                throw;
            }
            throw new NotImplementedException();
        }

        public Task<List<Students>> getAllStudents()
        {
            throw new NotImplementedException();
        }
    }
}
