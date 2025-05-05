using CourseWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CourseWorkTests
{
    public class StudentTests
    {
        StudentService studentService = new StudentService();

        [Fact]
        public void Confirmation_True()
        {
            bool record = true;

            studentService.LessonConfirmation(record);

            Assert.True(record);
        }

        [Fact]
        public void Confirmation_False()
        {
            bool record = false;

            studentService.LessonConfirmation(record);

            Assert.True(!record);
        }
    }
}
