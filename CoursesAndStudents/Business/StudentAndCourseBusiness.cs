using CoursesAndStudents.Datos.CQRS.Commands;
using CoursesAndStudents.Interfaces;
using CoursesAndStudents.Model;
using MediatR;

namespace CoursesAndStudents.Business
{
    public class StudentAndCourseBusiness : IStudentAndCourseBusiness, IPaymentGateway
    {
        private IMediator _mediator;
        private IPaymentGateway _paymentGateway;
        private ILogger<StudentAndCourseBusiness> _logger;
        public StudentAndCourseBusiness(IMediator mediator, ILogger<StudentAndCourseBusiness> logger, IPaymentGateway paymentGateway)
        {
            _mediator = mediator;
            _logger = logger;
            _paymentGateway = paymentGateway;
        }

        public async Task<StudentToCourse> AddStudentToCourse(StudentToCourse info)
        {
            StudentToCourse courses = new StudentToCourse();

            if(info.FirstName != null && info.Age > 18)
            {
                if (courses == null)
                {
                    throw new Exception("Course not found");
                }

                bool paymentSuccess = _paymentGateway.ProcessPayment(courses.Amount, courses.creditCardNumber, courses.cardHolderName, courses.expirationDate, courses.cvv);

                if (!paymentSuccess)
                {
                    throw new Exception("Payment failed");
                }
                else
                {
                    courses = await _mediator.Send(new AddStudentToCourseCommand { studentToCourse = info});
                    return courses;
                }
            }

            throw new NotImplementedException();
        }

        public async Task<List<StudentToCourse>> getAllStudentsAndCourse()
        {
            try
            {
                List<StudentToCourse> students = new List<StudentToCourse>();
                students = await _mediator.Send(new GetAllStudentsAndCoursesCommand());
                return students;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool ProcessPayment(decimal amount, string creditCardNumber, string cardHolderName, string expirationDate, string cvv)
        {
            throw new NotImplementedException();
        }
    }
}
