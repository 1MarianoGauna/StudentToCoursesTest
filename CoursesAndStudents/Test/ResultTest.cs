using CoursesAndStudents.Controllers;
using CoursesAndStudents.Model;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace CoursesAndStudents.Test
{
    public class ResultTest
    {
        private readonly CoursesandStudentsController _controller;
        public ResultTest(CoursesandStudentsController controller)
        {
            _controller = controller;
        }

        [Fact]
        public void CreateUser_ReturnsOkResult_WhenUserIsValid()
        {
            Students request = new Students();
            request.FirstName = "Test";
            request.Age = 19;
            var test = _controller.AddStudent(request);
            var OkResult = Assert.IsType<OkResult>(test);
        }

        [Fact]
        public void CreateUser_ReturnsBadRequest_WhenUserDataIsInvalid()
        {
            // Arrange
            Students request = new Students();
            request.FirstName = "";
            request.Age = 19;

            // Act
            var result = _controller.AddStudent(request);

            // Assert
            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal("Invalid user data.", badRequestResult.Value);
        }

        [Fact]
        public void CreateUser_ReturnsBadRequest_WhenRequestIsNull()
        {

            var result = _controller.AddStudent(null);

            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal("Invalid user data.", badRequestResult.Value);
        }
    }
}
