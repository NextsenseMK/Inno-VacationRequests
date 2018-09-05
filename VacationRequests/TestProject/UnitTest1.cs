using NS.Inno.Repository;
using System;
using Moq;
using NS.Inno.Common;
using NS.Inno.Data;
using Microsoft.Extensions.Options;
using NS.Inno.Business.Implementations;
using System.Collections.Generic;
using NS.Inno.Models;
using NS.Inno.Business.Interfaces;
using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class UnitTest1
    {

        [Test]
        public void CreateUser_Test()
        {
            var user = new User { UserName = "UserFromTest", DisplayName = "Testuser", EmploymentDate = DateTime.Now };

            var userRepositoryMock = new Mock<IRepository<User>>();
            userRepositoryMock.Setup(m => m.Insert(user)).Verifiable();

            var unitOfWorkMock = new Mock<IUnitOfWork>();
            unitOfWorkMock.Setup(m => m.UserRepository).Returns(userRepositoryMock.Object);

            IUserSystem sut = new UserSystem(unitOfWorkMock.Object);
            //Act
            sut.CreateUser(user);

            //Assert
            userRepositoryMock.Verify(r => r.Insert(user), Times.Once);
            unitOfWorkMock.Verify(u => u.SaveChanges(), Times.Once);
        }

        [Test]
        public void GetUserById_Test()
        {
            var userId = 1;
            var expected = "AAA";
            var user = new User { UserName = expected, Id = userId };

            var userRepositoryMock = new Mock<IRepository<User>>();
            userRepositoryMock.Setup(m => m.GetById(userId)).Returns(user).Verifiable();

            var unitOfWorkMock = new Mock<IUnitOfWork>();
            unitOfWorkMock.Setup(m => m.UserRepository).Returns(userRepositoryMock.Object);

            IUserSystem sut = new UserSystem(unitOfWorkMock.Object);
            //Act
            var actual = sut.GetUser(userId);

            //Assert
            userRepositoryMock.Verify();
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual.UserName);
        }

        
    }
}
