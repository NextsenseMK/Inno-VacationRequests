using NS.Inno.Repository;
using System;
using Xunit;
using Moq;
using NS.Inno.Common;
using NS.Inno.Repository.Repositories;
using NS.Inno.Data;
using Microsoft.Extensions.Options;
using NS.Inno.Business.Implementations;
using System.Collections.Generic;
using NS.Inno.Models;
using NS.Inno.Business.Interfaces;

namespace TestProject
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {

            //IList<User> products = new List<User>
            //    {
            //        new User { Id = 1, UserName = "C# Unleashed",
            //            DisplayName = "Short description here" },
            //        new User { Id = 2, UserName = "ASP.Net Unleashed",
            //            DisplayName = "Short description here" },
            //        new User { Id = 3, UserName = "Silverlight Unleashed",
            //            DisplayName = "Short description here" }
            //    };


            var unitOfWorkMock = new Mock<IUnitOfWork>();
            var configProviderMock = new Mock<IOptions<ConfigProvider>>();
            var userRepositoryMock = new Mock<IRepository<User>>();

          //  unitOfWorkMock.Object = userRepositoryMock.Object;
            IUserSystem iusersystem = new UserSystem(configProviderMock.Object, unitOfWorkMock.Object );
            iusersystem.GetUser(1);

           
           // userSystem.GetUser(new int());

            // Return all the products
            //     mockProductRepository.Setup(mr => mr.FindAll()).Returns(products);

            // return a product by Id
            //mockProductRepository.Setup(mr => mr.Get(
            //    It.IsAny<int>())).Returns((int i) => products.Where(
            //    x => x.ProductId == i).Single());

        }
    }
}
