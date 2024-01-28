using Newtonsoft.Json.Bson;

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void MyFloatsShouldNotBeEqual()
        {
            //arrange
            float myFloat1 = 1.11F;
            float myFloat2 = 2.22F;

            //act

            //assert
            Assert.That(myFloat1, Is.Not.EqualTo(myFloat2));
        }
        [Test]
        public void MyIntegersShouldBeEqual()
        {
            //arrange
            int myInt1 = 1;
            int myInt2 = 1;

            //act

            //assert
            Assert.AreEqual(myInt1, myInt2);
        }
        [Test]
        public void GetEmployeeShouldReturnDifferentObjects()
        {
            //arrange
            var employee1 = GetEmployee("Arnold", 0923);
            var employee2 = GetEmployee("Sylvester", 1287); 
            var employee3 = GetEmployee("Wojtek", 8947);
            var employee4 = GetEmployee("Weronika", 6572);

            //act

            //assert
            Assert.AreNotEqual(employee1.Name, employee1.IdCode, employee2.Name, employee2.IdCode, employee3.Name, employee3.IdCode, employee4.Name, employee4.IdCode);

        }
        [Test]
        public void GetEmployeeIdCodesAreDifferent()
        {
            //arrange
            var employee1 = GetEmployee("Arnold", 0923);
            var employee2 = GetEmployee("Arnold", 0897); 

            //act

            //assert
            Assert.That(employee1.IdCode, Is.Not.EqualTo(employee2.IdCode));

        }

        private Employee GetEmployee(string name, int idCode)
        {
            return new Employee(name, idCode);
        }
    }
}
