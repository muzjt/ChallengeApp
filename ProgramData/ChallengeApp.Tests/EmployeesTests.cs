using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void CheckIfSumOfPointsDesired()
        {
            //Arrange
            var employee = new Employee("Antoni", "Nowak", 55);
            employee.AddPoints(1);
            employee.AddPoints(5);

            //Act
            var sumOfPoints = employee.sumOfPoints;

            //Assert
            Assert.AreEqual(6, sumOfPoints);
        }
        [Test]
        public void PenaltyPointCheck()
        {
            //Arrange
            var employee = new Employee("Antoni", "Nowak", 55);
            employee.AddPoints(1);
            employee.AddPoints(5);
            employee.AddPoints(-1);

            //Act
            var sumOfPoints = employee.sumOfPoints;

            //Assert
            Assert.That(sumOfPoints, Is.EqualTo(5));
        }
        [Test]
        public void MultipleEarnedPointsByTwo()
        {
            //Arrange
            var employee = new Employee("Antoni", "Nowak", 55);
            employee.AddPoints(4 * 2);
            employee.AddPoints(2 * 2);


            //Act
            var sumOfPoints = employee.sumOfPoints;

            //Assert
            Assert.That(sumOfPoints, Is.EqualTo(12));
        }
        [Test]
        public void DivideEarnedPointsByThree()
        {
            //Arrange
            var employee = new Employee("Antoni", "Nowak", 55);
            employee.AddPoints(3 / 3);
            employee.AddPoints(9 / 3);


            //Act
            var sumOfPoints = employee.sumOfPoints;

            //Assert
            Assert.That(sumOfPoints, Is.EqualTo(4));
        }
    }
}