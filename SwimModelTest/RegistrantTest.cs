using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimModel;

namespace SwimModelTest
{
    [TestClass]
    public class RegistrantTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PhoneNumber_Is1DigitNot0_ShouldThrowArgumentException()
        {
            //Arrange
            Registrant aRegistrant = new Registrant();

            //Act
            aRegistrant.PhoneNumber = 1;

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PhoneNumber_Is9Digits_ShouldThrowArgumentException()
        {
            //Arrange
            Registrant aRegistrant = new Registrant();

            //Act
            aRegistrant.PhoneNumber = 123456789;

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PhoneNumber_Is11Digits_ShouldThrowArgumentException()
        {
            //Arrange
            Registrant aRegistrant = new Registrant();

            //Act
            aRegistrant.PhoneNumber = 12345678901;

            //Assert
        }

        [TestMethod]
        public void PhoneNumber_Is10Digits_ShouldUpdatePhoneNumber()
        {
            //Arrange
            Registrant aRegistrant = new Registrant();
            long phoneNum = 1234567890;

            //Act
            aRegistrant.PhoneNumber = phoneNum;

            //Assert
            Assert.AreEqual(aRegistrant.PhoneNumber, phoneNum);
        }

        [TestMethod]
        public void PhoneNumber_Is0_ShouldUpdatePhoneNumber()
        {
            //Arrange
            Registrant aRegistrant = new Registrant();
            long phoneNum = 0;

            //Act
            aRegistrant.PhoneNumber = phoneNum;

            //Assert
            Assert.AreEqual(aRegistrant.PhoneNumber, phoneNum);
        }

        [TestMethod]
        public void Registrant_Parameterless_ShouldHaveEmptyNameAddressPhoneNumberIs0()
        {
            //Arrange
            Registrant aRegistrant = new Registrant();

            //Act


            //Assert
            Assert.AreEqual(aRegistrant.Name, "");
            Assert.AreEqual(aRegistrant.Address.Street, null);
            Assert.AreEqual(aRegistrant.Address.City, null);
            Assert.AreEqual(aRegistrant.Address.Province, null);
            Assert.AreEqual(aRegistrant.Address.PostalCode, null);
            Assert.AreEqual(aRegistrant.PhoneNumber, 0);
        }

        [TestMethod]
        public void Registrant_WithNameParameter_ShouldHaveNameEmptyAddressPhoneNumberIs0()
        {
            //Arrange
            Registrant aRegistrant = new Registrant("name");

            //Act

            //Assert
            Assert.AreEqual(aRegistrant.Name, "name");
            Assert.AreEqual(aRegistrant.Address.Street, null);
            Assert.AreEqual(aRegistrant.Address.City, null);
            Assert.AreEqual(aRegistrant.Address.Province, null);
            Assert.AreEqual(aRegistrant.Address.PostalCode, null);
            Assert.AreEqual(aRegistrant.PhoneNumber, 0);
        }

        [TestMethod]
        public void Registrant_WithNameAndBirthParameter_ShouldHaveNameBirthEmptyAddressPhoneNumberIs0()
        {
            //Arrange
            Registrant aRegistrant = new Registrant("name", new DateTime(2000, 1, 1));

            //Act

            //Assert
            Assert.AreEqual(aRegistrant.Name, "name");
            Assert.AreEqual(new DateTime(2000, 1, 1), aRegistrant.DateOfBirth);
            Assert.AreEqual(aRegistrant.Address.Street, null);
            Assert.AreEqual(aRegistrant.Address.City, null);
            Assert.AreEqual(aRegistrant.Address.Province, null);
            Assert.AreEqual(aRegistrant.Address.PostalCode, null);
            Assert.AreEqual(aRegistrant.PhoneNumber, 0);
        }

        [TestMethod]
        public void Registrant_WithNameDoBAddressParameter_ShouldHaveNameDoBAddress()
        {
            //Arrange
            Address address = new Address("street", "city", "province", "postalCode");
            Registrant aRegistrant = new Registrant("name", new DateTime(2000, 1, 1), address);

            //Act

            //Assert
            Assert.AreEqual(aRegistrant.Name, "name");
            Assert.AreEqual(new DateTime(2000, 1, 1), aRegistrant.DateOfBirth);
            Assert.AreEqual(aRegistrant.Address, address);
        }

        [TestMethod]
        public void Registrant_WithNameDoBAddressPhoneNumParameter_ShouldHaveNameDoBAddressPhoneNum()
        {
            //Arrange
            Address address = new Address("street", "city", "province", "postalCode");
            Registrant aRegistrant = new Registrant("name", new DateTime(2000, 1, 1), address, 1234567890);

            //Act

            //Assert
            Assert.AreEqual(aRegistrant.Name, "name");
            Assert.AreEqual(new DateTime(2000, 1, 1), aRegistrant.DateOfBirth);
            Assert.AreEqual(aRegistrant.Address, address);
            Assert.AreEqual(aRegistrant.PhoneNumber, 1234567890);
        }

        [TestMethod]
        public void Registrant_WithNameAddressAndPhoneNumberClubParameter_ShouldHaveIDNameAddressPhoneNumberClub()
        {
            //Arrange
            Club aClub = new Club();
            Address address = new Address("street", "city", "province", "postalCode");
            Registrant aRegistrant = new Registrant("name", new DateTime(2000, 1, 1), address, 1234567890, aClub);

            //Act

            //Assert
            Assert.AreEqual(aRegistrant.Name, "name");
            Assert.AreEqual(new DateTime(2000, 1, 1), aRegistrant.DateOfBirth);
            Assert.AreEqual(aRegistrant.Address, address);
            Assert.AreEqual(aRegistrant.PhoneNumber, 1234567890);
            Assert.AreEqual(aClub, aRegistrant.Club);
        }

        [TestMethod]
        public void Registrant_WithIDNameAddressAndPhoneNumberParameter_ShouldHaveIDNameAddressPhoneNumber()
        {
            //Arrange
            Club aClub = new Club();
            Address address = new Address("street", "city", "province", "postalCode");
            Registrant aRegistrant = new Registrant(5, "name", new DateTime(2000, 1, 1), address, 1234567890);

            //Act

            //Assert
            Assert.AreEqual(aRegistrant.IdNum, 5);
            Assert.AreEqual(aRegistrant.Name, "name");
            Assert.AreEqual(new DateTime(2000, 1, 1), aRegistrant.DateOfBirth);
            Assert.AreEqual(aRegistrant.Address, address);
            Assert.AreEqual(aRegistrant.PhoneNumber, 1234567890);
        }

        [TestMethod]
        public void Registrant_WithIDNameAddressAndPhoneNumberClubParameter_ShouldHaveIDNameAddressPhoneNumberClub()
        {
            //Arrange
            Club aClub = new Club();
            Address address = new Address("street", "city", "province", "postalCode");
            Registrant aRegistrant = new Registrant(5, "name", new DateTime(2000, 1, 1), address, 1234567890, aClub);

            //Act

            //Assert
            Assert.AreEqual(aRegistrant.IdNum, 5);
            Assert.AreEqual(aRegistrant.Name, "name");
            Assert.AreEqual(new DateTime(2000, 1, 1), aRegistrant.DateOfBirth);
            Assert.AreEqual(aRegistrant.Address, address);
            Assert.AreEqual(aRegistrant.PhoneNumber, 1234567890);
            Assert.AreEqual(aClub, aRegistrant.Club);
        }

        [TestMethod]
        public void ToStringTestForGetPhoneInfo_WithPhoneNumber0_ShouldReturnNotAssigned()
        {
            //Arrange

            Registrant aRegistrant = new Registrant();

            //Act
            aRegistrant.PhoneNumber = 0;

            //Assert
            StringAssert.Contains(aRegistrant.ToString(), "not assigned");
        }

        [TestMethod]
        public void ToString_WithFullRegistrantInformation_ShouldReturnNameAddressPhoneClub()
        {
            //Arrange
            Club aClub = new Club("aClub");
            Address address = new Address("aStreet", "aCity", "aProvince", "aPostalCode");
            Registrant aRegistrant = new Registrant("aName", new DateTime(2000, 1, 1), address, 1234567890, aClub);

            //Act

            //Assert
            StringAssert.Contains(aRegistrant.ToString(), "aName", "Did not return name");
            StringAssert.Contains(aRegistrant.ToString(), "2000-01-01", "Did not return date of birth");
            StringAssert.Contains(aRegistrant.ToString(), "aStreet", "Did not return street");
            StringAssert.Contains(aRegistrant.ToString(), "aCity", "Did not return city");
            StringAssert.Contains(aRegistrant.ToString(), "aProvince", "Did not return province");
            StringAssert.Contains(aRegistrant.ToString(), "aPostalCode", "Did not return postalCode");
            StringAssert.Contains(aRegistrant.ToString(), "1234567890", "Did not return phone number");
            StringAssert.Contains(aRegistrant.ToString(), "aClub", "Did not return club");
        }

        [TestMethod]
        public void ToString_WithNoRegistrantClub_ShouldReturnClubNotAssigned()
        {
            //Arrange
            Registrant aRegistrant = new Registrant();

            //Act

            //Assert
            StringAssert.Contains(aRegistrant.ToString(), "not assigned");
        }

        [TestMethod]
        public void Club_SetNewClub_ShouldSetClub()
        {
            //Arrange
            Club aClub = new Club();
            Registrant aRegistrant = new Registrant();
            aRegistrant.Club = aClub;

            //Act

            //Assert
            Assert.AreEqual(aClub, aRegistrant.Club);
        }

        [TestMethod]
        public void Club_SetClubAlreadyExists_ShouldThrowException()
        {
            //Arrange
            Club aClub = new Club();
            Registrant aRegistrant = new Registrant("name", new DateTime(2000, 1, 1), new Address(), 1234567890, aClub);
            
            //Act

            //Assert
            try
            {
                aRegistrant.Club = new Club();
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "Registrant already registered");
                return;
            }
            Assert.Fail();
        }       
    }
}
