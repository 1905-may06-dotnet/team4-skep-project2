using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using webapi.Controllers;
using Domain;
using System.Net.Http;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data.SqlClient;

namespace Test
{
     [TestClass]
     public class ProfileTest{
          [TestMethod]
          public void UpdateEmailTest(){
               var mock = new Mock<Data.Repo>();
               Guid g = Guid.NewGuid();
               mock.Setup(x => x.UsernameExist("test")).Returns(true);
               var user = new BGUser();
               user.New = "testing";
               user.Token = g;
               user.Username = "test";
               ProfileController profileController = new ProfileController(mock.Object);
               var response = profileController.UpdateEmail(user);
               Assert.IsNotNull(response);
               Assert.IsInstanceOfType(response, typeof(AcceptedResult));
          }
          [TestMethod]
          public void UpdateEmailTestFail(){
               var mock = new Mock<Data.Repo>();
               Guid g = Guid.NewGuid();
               mock.Setup(x => x.UsernameExist("test")).Returns(true);
               var user = new BGUser();
               user.New = "testing";
               user.Token = g;
               ProfileController profileController = new ProfileController(mock.Object);
               var response = profileController.UpdateEmail(user);
               Assert.IsNotNull(response);
               Assert.IsInstanceOfType(response, typeof(BadRequestResult));
          }
          [TestMethod]
          public void UpdatePhoneTest(){
               var mock = new Mock<Data.Repo>();
               Guid g = Guid.NewGuid();
               mock.Setup(x => x.UsernameExist("test")).Returns(true);
               var user = new BGUser();
               user.New = "testing";
               user.Token = g;
               user.Username = "test";
               ProfileController profileController = new ProfileController(mock.Object);
               var response = profileController.UpdatePhone(user);
               Assert.IsNotNull(response);
               Assert.IsInstanceOfType(response, typeof(AcceptedResult));
          }
          [TestMethod]
          public void UpdatePhoneTestFail(){
               var mock = new Mock<Data.Repo>();
               Guid g = Guid.NewGuid();
               mock.Setup(x => x.UsernameExist("test")).Returns(true);
               var user = new BGUser();
               user.New = "testing";
               user.Token = g;
               user.Username = "testing";
               ProfileController profileController = new ProfileController(mock.Object);
               var response = profileController.UpdatePhone(user);
               Assert.IsNotNull(response);
               Assert.IsInstanceOfType(response, typeof(BadRequestResult));
          }
    }
}