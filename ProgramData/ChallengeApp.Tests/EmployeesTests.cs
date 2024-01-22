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
            Assert.AreEqual(1 + 5, sumOfPoints);
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
            Assert.That(sumOfPoints, Is.EqualTo(1 + 5 + (-1)));
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
            Assert.That(sumOfPoints, Is.EqualTo(2 * 2 + 4 * 2));
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
            Assert.That(sumOfPoints, Is.EqualTo(3 / 3 + 9 / 3));
        }
    }
}