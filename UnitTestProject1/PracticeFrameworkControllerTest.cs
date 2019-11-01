using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PracticeFramework.Models.Response;
using PracticeFramework.Services;
using PracticeFramework.Controllers;
using System.Web;
using System.Web.Http;

namespace UnitTestProject1
{
    [TestClass]
    public class PracticeFrameworkControllerTest
    {
        [TestMethod]
        public void GetAll_Should_Return_Expected_Values()
        {
            //Arrange
            var practiceFrameworkViewModel = new List<PracticeFrameworkViewModel>();

            practiceFrameworkViewModel.Add(new PracticeFrameworkViewModel { id = 1, description = "Test" });
            practiceFrameworkViewModel.Add(new PracticeFrameworkViewModel { id = 2, description = "Test2" });
            practiceFrameworkViewModel.Add(new PracticeFrameworkViewModel { id = 3, description = "Test3" });

            var PracticeFrameworkMock = new Mock<IPracticeFramework>();
            var PracticeFrameworkController = new PracticeFrameworkController(PracticeFrameworkMock.Object);

            PracticeFrameworkMock.Setup(x => x.Get()).Returns(practiceFrameworkViewModel);

            //Act
            var result = PracticeFrameworkController.GetAll();

            //Assert
            Assert.AreEqual(practiceFrameworkViewModel, result);
        }
    }
}
