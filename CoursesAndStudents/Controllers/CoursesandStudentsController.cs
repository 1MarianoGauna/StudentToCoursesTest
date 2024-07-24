using CoursesAndStudents.Business;
using CoursesAndStudents.Interfaces;
using CoursesAndStudents.Model;
using Microsoft.AspNetCore.Mvc;

namespace CoursesAndStudents.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoursesandStudentsController : ControllerBase
    {
        private readonly ILogger<CoursesandStudentsController> _logger;
        private readonly ICoursesBusiness _coursesBusiness;
        private readonly IStudentsBusiness _studentsBusiness;
        private readonly IStudentAndCourseBusiness _studentAndCourseBusiness;

        public CoursesandStudentsController(ILogger<CoursesandStudentsController> logger, ICoursesBusiness coursesBusiness, IStudentsBusiness studentsBusiness, IStudentAndCourseBusiness studentAndCourseBusiness)
        {
            _logger = logger;
            _coursesBusiness = coursesBusiness;
            _studentsBusiness = studentsBusiness;
            _studentAndCourseBusiness = studentAndCourseBusiness;
        }

        [HttpPost]
        public async Task<List<Courses>> AddCourse()
        {
            try
            {
                List<Courses> courses = new List<Courses>();
                courses = await _coursesBusiness.getAllCourses();
                return courses;
            }
            catch (Exception ex)
            {
                _logger.LogError($"ERROR EN EL METODO:{ex.Message}");
                throw;
            }
        } 

        [HttpPost]
        public async Task<Students> AddStudent(Students students)
        {
            try
            {
                Students student = new Students();
                if(student != null)
                {
                    student = await _studentsBusiness.AddStudent(student);
                    return student;
                }
                return student;
            }
            catch (Exception ex)
            {
                _logger.LogError($"ERROR EN EL METODO:{ex.Message}");
                throw;
            }
        }
        
        [HttpPost]
        public async Task<StudentToCourse> AddStudentToCourse(StudentToCourse information)
        {
            try
            {
                StudentToCourse infor = new StudentToCourse();
                if(infor != null)
                {
                    infor = await _studentAndCourseBusiness.AddStudentToCourse(infor);
                    return infor;
                }
                return infor;
            }
            catch (Exception ex)
            {
                _logger.LogError($"ERROR EN EL METODO:{ex.Message}");
                throw;
            }
        }


        [HttpGet]
        public async Task<List<StudentToCourse>> GetAllStudentsAndCourses()
        {
            try
            {
                List<StudentToCourse> students = new List<StudentToCourse>();
                students = await _studentAndCourseBusiness.getAllStudentsAndCourse();
                return students;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}