using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimModel;

namespace SwimModelTest
{
    [TestClass]
    public class ClubTest
    {
        // TO DO: ADD AUTO-IMPLEMENT PROPERTIES

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PhoneNumber_Is1DigitNot0_ShouldThrowArgumentException()
        {
            //Arrange
            Club aClub = new Club();

            //Act
            aClub.PhoneNumber = 1;

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PhoneNumber_Is9Digits_ShouldThrowArgumentException()
        {
            //Arrange
            Club aClub = new Club();

            //Act
            aClub.PhoneNumber = 123456789;

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PhoneNumber_Is11Digits_ShouldThrowArgumentException()
        {
            //Arrange
            Club aClub = new Club();

            //Act
            aClub.PhoneNumber = 12345678901;

            //Assert
        }

        [TestMethod]
        public void PhoneNumber_Is10Digits_ShouldUpdatePhoneNumber()
        {
            //Arrange
            Club aClub = new Club();
            long phoneNum = 1234567890;

            //Act
            aClub.PhoneNumber = phoneNum;

            //Assert
            Assert.AreEqual(aClub.PhoneNumber, phoneNum);
        }

        [TestMethod]
        public void PhoneNumber_Is0_ShouldUpdatePhoneNumber()
        {
            //Arrange
            Club aClub = new Club();
            long phoneNum = 0;

            //Act
            aClub.PhoneNumber = phoneNum;

            //Assert
            Assert.AreEqual(aClub.PhoneNumber, phoneNum);
        }

        [TestMethod]
        public void Club_Parameterless_ShouldHaveEmptyNameAddressPhoneNumberIs0()
        {
            //Arrange
            Club aClub = new Club();

            //Act

            //Assert
            Assert.AreEqual(aClub.Name, "");
            Assert.AreEqual(aClub.Address.Street, null);
            Assert.AreEqual(aClub.Address.City, null);
            Assert.AreEqual(aClub.Address.Province, null);
            Assert.AreEqual(aClub.Address.PostalCode, null);
            Assert.AreEqual(aClub.PhoneNumber, 0);
        }

        [TestMethod]
        public void Club_WithNameParameter_ShouldHaveNameEmptyAddressPhoneNumberIs0()
        {
            //Arrange
            Club aClub = new Club("name");

            //Act

            //Assert
            Assert.AreEqual(aClub.Name, "name");
            Assert.AreEqual(aClub.Address.Street, null);
            Assert.AreEqual(aClub.Address.City, null);
            Assert.AreEqual(aClub.Address.Province, null);
            Assert.AreEqual(aClub.Address.PostalCode, null);
            Assert.AreEqual(aClub.PhoneNumber, 0);
        }

        [TestMethod]
        public void Club_WithNameAndAddressParameter_ShouldHaveNameAddressPhoneNumberIs0()
        {
            //Arrange
            Address address = new Address("street", "city", "province", "postalCode");
            Club aClub = new Club("name", address);

            //Act

            //Assert
            Assert.AreEqual(aClub.Name, "name");
            Assert.AreEqual(aClub.Address, address);
            Assert.AreEqual(aClub.PhoneNumber, 0);
        }

        [TestMethod]
        public void Club_WithNameAddressAndPhoneNumberParameter_ShouldHaveNameAddressPhoneNumber()
        {
            //Arrange
            Address address = new Address("street", "city", "province", "postalCode");
            Club aClub = new Club("name", address, 1234567890);

            //Act

            //Assert
            Assert.AreEqual(aClub.Name, "name");
            Assert.AreEqual(aClub.Address, address);
            Assert.AreEqual(aClub.PhoneNumber, 1234567890);
        }

        [TestMethod]
        public void Club_WithIDNameAddressAndPhoneNumberParameter_ShouldHaveIDNameAddressPhoneNumber()
        {
            //Arrange
            Address address = new Address("street", "city", "province", "postalCode");
            Club aClub = new Club(123, "name", address, 1234567890);

            //Act

            //Assert
            Assert.AreEqual(aClub.IdNum, 123);
            Assert.AreEqual(aClub.Name, "name");
            Assert.AreEqual(aClub.Address, address);
            Assert.AreEqual(aClub.PhoneNumber, 1234567890);
        }

        [TestMethod]
        public void ToStringTestForGetPhoneInfo_WithPhoneNumber0_ShouldReturnNotAssigned()
        {
            //Arrange

            Club aClub = new Club();

            //Act
            aClub.PhoneNumber = 0;

            //Assert
            StringAssert.Contains(aClub.ToString(), "not assigned");
        }

        [TestMethod]
        public void ToString_WithFullClubInformation_ShouldReturnNameAddressPhoneID()
        {
            //Arrange
            Address address = new Address("aStreet", "aCity", "aProvince", "aPostalCode");
            Club aClub = new Club(123, "aName", address, 1234567890);

            //Act

            //Assert
            StringAssert.Contains(aClub.ToString(), "aName", "Did not return name");
            StringAssert.Contains(aClub.ToString(), "aStreet", "Did not return street");
            StringAssert.Contains(aClub.ToString(), "aCity", "Did not return city");
            StringAssert.Contains(aClub.ToString(), "aProvince", "Did not return province");
            StringAssert.Contains(aClub.ToString(), "aPostalCode", "Did not return postalCode");
            StringAssert.Contains(aClub.ToString(), "1234567890", "Did not return phone number");
            StringAssert.Contains(aClub.ToString(), "123", "Did not return ID number");
        }

        [TestMethod]
        public void GetRegistrantListTestWithToString_WithAddSwimmerMethod_ShouldReturnRegistrantList()
        {
            //Arrange
            Club aClub = new Club();

            //Act
            aClub.AddSwimmer(new Swimmer("Bob"));
            aClub.AddSwimmer(new Swimmer("Billy"));

            //Assert           
            StringAssert.Contains(aClub.ToString(), "Bob", "Did not return registrant list [0]");
            StringAssert.Contains(aClub.ToString(), "Billy", "Did not return registrant list [1]");
        }

        [TestMethod]
        public void GetCoachListTestWithToString_WithAddCoachMethod_ShouldReturnCoachList()
        {
            //Arrange
            Club aClub = new Club();

            //Act
            aClub.AddCoach(new Coach("aCoach"));
            aClub.AddCoach(new Coach("bCoach"));

            //Assert           
            StringAssert.Contains(aClub.ToString(), "aCoach", "Did not return coach list [0]");
            StringAssert.Contains(aClub.ToString(), "bCoach", "Did not return coach list [1]");
        }

        [TestMethod]
        public void AddSwimmer_ThisClubAndNotAlreadyInRegistrantList_ShouldAddRegistrantToList()
        {
            //Arrange
            Club aClub = new Club();
            Swimmer aSwimmer = new Swimmer("Bob");

            //Act
            aClub.AddSwimmer(aSwimmer);

            //Assert           
            Assert.ReferenceEquals(aClub.ClubMembers[0], aSwimmer);
        }

        [TestMethod]
        public void AddSwimmer_AddSameSwimmerTwice_ShouldReturnException()
        {
            //Arrange
            Club aClub = new Club();
            Swimmer aSwimmer = new Swimmer("Bob");

            //Act
            aClub.AddSwimmer(aSwimmer);
            try
            {
                aClub.AddSwimmer(aSwimmer);
            }
            catch (Exception e)
            {
                //Assert           
                StringAssert.Contains(e.Message, "already registered with club");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");          
        }

        [TestMethod]
        public void AddSwimmer_AlreadyHasClub_ShouldReturnException()
        {
            //Arrange
            Club aClub = new Club();
            Swimmer aSwimmer = new Swimmer("Bob");

            //Act
            aSwimmer.Club = new Club("Club2");
            try
            {
                aClub.AddSwimmer(aSwimmer);
            }
            catch (Exception e)
            {
                //Assert           
                StringAssert.Contains(e.Message, "Registrant already registered");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        public void AddCoach_AlreadyHasCoach_ShouldReturnException()
        {
            //Arrange
            Club aClub = new Club();
            Coach aCoach = new Coach("aCoach");

            //Act
            aCoach.Club = new Club("Club2");
            try
            {
                aClub.AddCoach(aCoach);
            }
            catch (Exception e)
            {
                //Assert           
                StringAssert.Contains(e.Message, "Coach already registered");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        public void AddCoach_AddSameCoachTwice_ShouldReturnException()
        {
            //Arrange
            Club aClub = new Club();
            Coach aCoach = new Coach("aCoach");

            //Act
            aClub.AddCoach(aCoach);
            try
            {
                aClub.AddCoach(aCoach);
            }
            catch (Exception e)
            {
                //Assert           
                StringAssert.Contains(e.Message, "already registered to this club");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        public void AddCoach_ThisClubAndNotAlreadyInCoachList_ShouldAddCoachToList()
        {
            //Arrange
            Club aClub = new Club();
            Coach aCoach = new Coach("aCoach");

            //Act
            aClub.AddCoach(aCoach);

            //Assert           
            Assert.ReferenceEquals(aClub.CoachList[0], aCoach);
        }
    }
}
