using CourseWork;
using Moq;
using System;
using Xunit;

namespace CourseWorkTests
{
    public class InstructionTests
    {

        InstructionService instructionService = new InstructionService();

        [Fact]
        public void Confirmation_True()
        {
            bool record = true;

            instructionService.Confirmation(record);

            Assert.True(record);
        }

        [Fact]
        public void Confirmation_False()
        {
            bool record = false;

            instructionService.Confirmation(record);

            Assert.True(!record);
        }
    }
}
