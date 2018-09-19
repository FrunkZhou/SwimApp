using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimModel;

namespace SwimModelTest
{
    [TestClass]
    public class AddressTest
    {
        [TestMethod]
        public void Address_WithProperValues_ShouldCreateAddress()
        {
            //Arrange
            Address anAddress = new Address("aStreet", "aCity", "aProvince", "aPostal");

            //Act

            //Assert
            StringAssert.Contains(anAddress.ToString(), "aStreet");
            StringAssert.Contains(anAddress.ToString(), "aCity");
            StringAssert.Contains(anAddress.ToString(), "aProvince");
            StringAssert.Contains(anAddress.ToString(), "aPostal");
        }
    }
}
