using NUnit.Framework;
using TestNinja.Fundamentals;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TestNinja.UnitTests
{
    [Ignore("Because I'm not using it in this section")]
    [TestFixture]
    public class MathTests
    {
        private Fundamentals.Math _math;

        [Ignore("Because I'm not using it in this section")]
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

        [Ignore("Because I'm not using it in this section")]
        [Test]
        //[Ignore("Because I wanted to!")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            //var math = new Fundamentals.Math();

            var result = this._math.Add(1, 2);

            //Assert.That(_math, Is.Not.Null);
            Assert.That(result, Is.EqualTo(3));

        }

        [Ignore("Because I'm not using it in this section")]
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

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = this._math.GetOddNumbers(5);

            //Assert.That(result, Is.Not.Empty);
            //Assert.That(result.Count(), Is.EqualTo(3));

            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 })); //This line of code is equivalent to the last 3

            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique); //With this we make sure that there are no duplicated items in the array

        }

        //[Test]
        //public void GetOddNumbers_LimitIsLessThanZero_ReturnOddNumbersUpToLimit() //Less than and equal to 0 wont work and thats ok
        //{
        //    var result = this._math.GetOddNumbers(0);

        //    Assert.That(result, Is.Not.Empty);
        //    //Assert.That(result.Count(), Is.EqualTo(3));

        //    //Assert.That(result, Does.Contain(1));
        //    //Assert.That(result, Does.Contain(3));
        //    //Assert.That(result, Does.Contain(5));

        //    //Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 })); //This line of code is equivalent to the last 3

        //    //Assert.That(result, Is.Ordered);
        //    //Assert.That(result, Is.Unique); //With this we make sure that there are no duplicated items in the array

        //}
    }
}
