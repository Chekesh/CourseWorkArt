using CourseWork;
using Moq;
using System;
using Xunit;
namespace CourseWorkTests
{
    public class AuthoTest
    {
        AuhtoService auhtoService = new AuhtoService();
        Mock<BDService> mockDbService = new Mock<BDService>();
        //BD Connection = new BD();
        String login = "уау";
        String pass = "1234";
        [Fact]
        public void InstructorORStudent_Instructor()
        {
            login = "GILZA";
            pass = "1234";
            mockDbService.Setup(db => db.IsUserBD(login, pass)).Returns(2);

            String user = auhtoService.InstructorORStudent(login, pass, mockDbService.Object.IsUserBD(login, pass));
        
            Assert.True(user == "INSTRUCTOR");
        }

        [Fact]
        public void InstructorORStudent_Student()
        {
            login = "Kalgun";
            pass = "Kalgun";
            mockDbService.Setup(db => db.IsUserBD(login, pass)).Returns(1);

            String user = auhtoService.InstructorORStudent(login, pass, mockDbService.Object.IsUserBD(login, pass));

            Assert.True(user == "STUDENT");
        }

        [Fact]
        public void InstructorORStudent_ErrorNotExist()
        {
            login = "GILZA";
            pass = "1";
            mockDbService.Setup(db => db.IsUserBD(login, pass)).Returns(0);

            String user = auhtoService.InstructorORStudent(login, pass, mockDbService.Object.IsUserBD(login, pass));

            Assert.True(user == "USER");
        }

        [Fact]
        public void InstructorORStudent_ErrorEmpty()
        {
            login = "GILZA";
            pass = "";
            mockDbService.Setup(db => db.IsUserBD(login, pass)).Returns(0);

            String user = auhtoService.InstructorORStudent(login, pass, mockDbService.Object.IsUserBD(login, pass));

            Assert.True(user == "USER");
        }
    }
}