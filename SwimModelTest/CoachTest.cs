using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimModel;

namespace SwimModelTest
{
    [TestClass]
    public class CoachTest
    {
        [TestMethod]
        public void Coach_Parameterless_ShouldHaveEmptyNameAddressPhoneNumberIs0()
        {
            //Arrange
            Coach aCoach = new Coach();

            //Act

            //Assert
            Assert.AreEqual(aCoach.Name, "");
            Assert.AreEqual(aCoach.Address.Street, null);
            Assert.AreEqual(aCoach.Address.City, null);
            Assert.AreEqual(aCoach.Address.Province, null);
            Assert.AreEqual(aCoach.Address.PostalCode, null);
            Assert.AreEqual(aCoach.PhoneNumber, 0);
        }

        [TestMethod]
        public void Coach_WithNameParameter_ShouldHaveNameEmptyAddressPhoneNumberIs0()
        {
            //Arrange
            Coach aCoach = new Coach("name");

            //Act

            //Assert
            Assert.AreEqual(aCoach.Name, "name");
            Assert.AreEqual(aCoach.Address.Street, null);
            Assert.AreEqual(aCoach.Address.City, null);
            Assert.AreEqual(aCoach.Address.Province, null);
            Assert.AreEqual(aCoach.Address.PostalCode, null);
            Assert.AreEqual(aCoach.PhoneNumber, 0);
        }

        [TestMethod]
        public void Coach_WithNameDoBAddressPhoneNumParameter_ShouldHaveNameDoBAddressPhoneNum()
        {
            //Arrange
            Address address = new Address("street", "city", "province", "postalCode");
            Coach aCoach = new Coach("name", new DateTime(2000, 1, 1), address, 1234567890);

            //Act

            //Assert
            Assert.AreEqual(aCoach.Name, "name");
            Assert.AreEqual(new DateTime(2000, 1, 1), aCoach.DateOfBirth);
            Assert.AreEqual(aCoach.Address, address);
            Assert.AreEqual(aCoach.PhoneNumber, 1234567890);
        }

        [TestMethod]
        public void Coach_WithNameAddressAndPhoneNumberClubCredentialParameter_ShouldHaveIDNameAddressPhoneNumberClubCredential()
        {
            //Arrange
            Club aClub = new Club();
            Address address = new Address("street", "city", "province", "postalCode");
            Coach aCoach = new Coach("name", new DateTime(2000, 1, 1), address, 1234567890, aClub, "someCred");

            //Act

            //Assert
            Assert.AreEqual(aCoach.Name, "name");
            Assert.AreEqual(new DateTime(2000, 1, 1), aCoach.DateOfBirth);
            Assert.AreEqual(aCoach.Address, address);
            Assert.AreEqual(aCoach.PhoneNumber, 1234567890);
            Assert.AreEqual(aCoach.Club, aClub);
            Assert.AreEqual(aCoach.Credentials, "someCred");
        }

        [TestMethod]
        public void Club_SetNewClub_ShouldSetClub()
        {
            //Arrange
            Club aClub = new Club();
            Coach aCoach = new Coach();
            aCoach.Club = aClub;

            //Act

            //Assert
            Assert.AreEqual(aClub, aCoach.Club);
        }

        [TestMethod]
        public void Club_SetClubAlreadyExists_ShouldThrowException()
        {
            //Arrange
            Club aClub = new Club();
            Coach aCoach = new Coach("name", new DateTime(2000, 1, 1), new Address(), 1234567890, aClub, "");

            //Act

            //Assert
            try
            {
                aCoach.Club = new Club(); ;
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "Coach already registered");
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void AddSwimmer_CoachHasNoClub_ShouldReturnException()
        {
            //Arrange
            Coach aCoach = new Coach();
            Swimmer aSwimmer = new Swimmer();
            aSwimmer.Club = new Club();

            //Act
            try
            {
                aCoach.AddSwimmer(aSwimmer);
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "Coach");
                StringAssert.Contains(e.Message, "does not belong to a club");
                return;
            }

            //Assert
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        public void AddSwimmer_SwimmerHasNoClub_ShouldReturnException()
        {
            //Arrange
            Coach aCoach = new Coach();
            Swimmer aSwimmer = new Swimmer();
            aCoach.Club = new Club();

            //Act
            try
            {
                aCoach.AddSwimmer(aSwimmer);
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "Swimmer");
                StringAssert.Contains(e.Message, "does not belong to a club");
                return;
            }

            //Assert
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        public void AddSwimmer_CoachAndSwimmerHasDiffClubs_ShouldReturnException()
        {
            //Arrange
            Coach aCoach = new Coach();
            Swimmer aSwimmer = new Swimmer();
            aCoach.Club = new Club("aClub");
            aSwimmer.Club = new Club("bClub");

            //Act
            try
            {
                aCoach.AddSwimmer(aSwimmer);
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "does not belong to the same club");
                return;
            }

            //Assert
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        public void AddSwimmer_CoachAndSimmerHasSameClub_ShouldAddCoach()
        {
            //Arrange
            Club aClub = new Club();
            Club bClub = new Club();
            Swimmer aSwimmer = new Swimmer();
            Coach aCoach = new Coach();
            aCoach.Club = aClub;
            aSwimmer.Club = aClub;

            //Act
            aCoach.AddSwimmer(aSwimmer);


            //Assert
            Assert.AreEqual(aCoach.SwimmersList[0], aSwimmer);
        }
        
        [TestMethod]
        public void getStudentsListWithToString_WithProperStudnets_ShouldReturnList()
        {
            //Arrange
            Club aClub = new Club();
            Coach aCoach = new Coach();
            Swimmer aSwimmer = new Swimmer("Alice");
            Swimmer bSwimmer = new Swimmer("Bob");
            aCoach.Club = aClub;
            aSwimmer.Club = aClub;
            bSwimmer.Club = aClub;

            //Act     
            aCoach.AddSwimmer(aSwimmer);
            aCoach.AddSwimmer(bSwimmer);

            //Assert
            StringAssert.Contains(aCoach.ToString(), "Alice");
            StringAssert.Contains(aCoach.ToString(), "Bob");
        }

        [TestMethod]
        public void ToString_WithCredentials_ShouldReturnCredentials()
        {
            //Arrange
            Coach aCoach = new Coach();


            //Act     
            aCoach.Credentials = "creds";

            //Assert
            StringAssert.Contains(aCoach.ToString(), "creds");
        }
    }
}
