using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [Ignore("Because I'm not using it in this section")]
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue() //Method_Scenario_ExpectedBehaviour
        {
            //Inside every test method we have 3 parts: Arrange, Act and Assert (AAA [Triple A] Convention)
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            //Assert.IsTrue(result);
            //Assert.That(result == true);
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancellingReservation_ReturnsTrue() 
        {
            var user = new User { IsAdmin = false };
            var reservation = new Reservation { MadeBy = user };

            var result = reservation.CanBeCancelledBy(user);

            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnsFalse() 
        {
            //var maker = new User();
            var reservation = new Reservation { MadeBy = new User() /*maker*/ };

            //var user = new User { IsAdmin = false };

            var result = reservation.CanBeCancelledBy(new User());

            Assert.That(result, Is.False);
        }
    }
}
