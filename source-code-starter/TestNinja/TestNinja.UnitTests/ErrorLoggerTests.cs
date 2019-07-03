using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {

        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var errorMessage = "New error!";
            var logger = new ErrorLogger();

            logger.Log(errorMessage);

            Assert.That(logger.LastError, Is.EqualTo(errorMessage));
        }

    }
}
