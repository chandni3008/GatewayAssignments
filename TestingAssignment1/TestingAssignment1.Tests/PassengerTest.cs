using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Results;
using TestingAssignment1.Controllers;
using TestingAssignment1.Models;
using TestingAssignment1.Repository;
using Xunit;

namespace TestingAssignment1.Tests
{
   public class PassengerTest
    {
        private readonly Mock<IDataRepository> mockRepository = new Mock<IDataRepository>();
        private readonly PassengerController _passengerController;

        public PassengerTest()
        {
            _passengerController = new PassengerController(mockRepository.Object);
        }

        [Fact]
        public void Test_GetUser()
        {
            // Arrange
            var resultObj = mockRepository.Setup(x => x.getPassengersList()).Returns(GetPassengers());

            // Act
            var response = _passengerController.GetList();

            // Assert
            Assert.Equal(3, response.Count);
        }

        [Fact]
        public void Test_DeleteUser()
        {
            var user = new Passenger();
            user.Id = Guid.NewGuid();
            // Arrange
            var resultObj = mockRepository.Setup(x => x.Delete(user.Id)).Returns(true);

            // Act
            var response = _passengerController.Delete(user.Id);

            //Assert
            Assert.True(response);

        }

        [Fact]
        public void Test_GetUserById()
        {
            // Arrange
            var user = new Passenger();
            user.Id = Guid.NewGuid();
            user.FirstName = "Chandni";
            user.LastName = "Chandwani";
            user.PhoneNumber = "1212121212";

            // Act
            var responseObj = mockRepository.Setup(x => x.GetById(user.Id)).Returns(user);
            var result = _passengerController.Get(user.Id);
            var isNull = Assert.IsType<OkNegotiatedContentResult<Passenger>>(result);
            // Assert
            Assert.NotNull(isNull);
        }

        [Fact]
        public void Test_AddUser()
        {
            var newUser = new Passenger();
            newUser.Id = Guid.NewGuid();
            newUser.FirstName = "Fuser1";
            newUser.LastName = "Luser1";
            newUser.PhoneNumber = "1234567";

            // Act
            var response = mockRepository.Setup(x => x.AddPassenger(newUser)).Returns(AddUser());
            var result = _passengerController.Create(newUser);

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Test_UpdateUser()
        {
            // Arrange
            var model = GetOnlyPassenger();

            // Act
            var resultObj = mockRepository.Setup(x => x.Update(model)).Returns(model);
            var response = _passengerController.Update(model);

            // Assert
            Assert.Equal(model, response);
        }

        private static IList<Passenger> GetPassengers()
        {
            IList<Passenger> passengers = new List<Passenger>()
            {
                new Passenger() {Id=Guid.NewGuid(), FirstName="Chandni", LastName="Chandwani", PhoneNumber = "98989898"},
                new Passenger() {Id=Guid.NewGuid(), FirstName="Fuser1", LastName="Luser1", PhoneNumber = "1234567"},
                new Passenger() {Id=Guid.NewGuid(), FirstName="Fuser2", LastName="Luser2", PhoneNumber = "12121212"},

            };
            return passengers;
        }

        private static Passenger AddUser()
        {
            var newUser = new Passenger();
            newUser.Id = Guid.NewGuid();
            newUser.FirstName = "Ram";
            newUser.LastName = "Shyam";
            newUser.PhoneNumber = "45454545";
            return newUser;
        }

        private Passenger GetOnlyPassenger()
        {
            return new Passenger
            {
                Id = Guid.NewGuid(),
                FirstName = "NewUser",
                LastName = "NewUser",
                PhoneNumber = "123132144"
            };
        }
    }
}

