using NUnit.Framework;
using TestNinja.Fundamentals;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Fundamentals.Math _math;

        [SetUp] //SetUp: NUnit will call this method BEFORE each test.
        public void SetUp()
        {
            this._math = new Fundamentals.Math();
        }

        //[TearDown] //TearDown: NUnit will call this method AFTER each test.
        //public void TearDown()
        //{
        //    this._math.Dispose(); //Just for example purposes
        //}

        [Test]
        [Ignore("Because I wanted to!")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            //var math = new Fundamentals.Math();

            var result = this._math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnGreaterArgument(int a, int b, int expectedReturn) //Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        {
            var result = this._math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedReturn));
        }

        //[Test]
        //public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        //{
        //    var result = this._math.Max(1, 2);

        //    Assert.That(result, Is.EqualTo(2));
        //}

        //[Test]
        //public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        //{
        //    var result = this._math.Max(1, 1);

        //    Assert.That(result, Is.EqualTo(1));
        //}
    }
}
