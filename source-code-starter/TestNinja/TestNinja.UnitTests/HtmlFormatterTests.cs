using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {

        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");

            //Specific Assertion
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);

            //More General Assertion
            Assert.That(result, Does.StartWith("<strong>")); //Pretty weak assertion...
            Assert.That(result, Does.EndWith("</strong>")); //Still weak...
            Assert.That(result, Does.Contain("abc").IgnoreCase);   //together with the last 2 assertions will make a trustworthy test!!!
        }

    }
}
