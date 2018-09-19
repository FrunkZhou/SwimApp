using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimModel;

namespace SwimModelTest
{
    [TestClass]
    public class SwimmerTest
    {
        [TestMethod]
        public void Swimmer_Parameterless_ShouldHaveEmptyNameAddressPhoneNumberIs0()
        {
            //Arrange
            Swimmer aSwimmer = new Swimmer();

            //Act

            //Assert
            Assert.AreEqual(aSwimmer.Name, "");
            Assert.AreEqual(aSwimmer.Address.Street, null);
            Assert.AreEqual(aSwimmer.Address.City, null);
            Assert.AreEqual(aSwimmer.Address.Province, null);
            Assert.AreEqual(aSwimmer.Address.PostalCode, null);
            Assert.AreEqual(aSwimmer.PhoneNumber, 0);
        }

        [TestMethod]
        public void Swimmer_WithNameParameter_ShouldHaveNameEmptyAddressPhoneNumberIs0()
        {
            //Arrange
            Swimmer aSwimmer = new Swimmer("name");

            //Act

            //Assert
            Assert.AreEqual(aSwimmer.Name, "name");
            Assert.AreEqual(aSwimmer.Address.Street, null);
            Assert.AreEqual(aSwimmer.Address.City, null);
            Assert.AreEqual(aSwimmer.Address.Province, null);
            Assert.AreEqual(aSwimmer.Address.PostalCode, null);
            Assert.AreEqual(aSwimmer.PhoneNumber, 0);
        }

        [TestMethod]
        public void Swimmer_WithNameDoBAddressPhoneNumParameter_ShouldHaveNameDoBAddressPhoneNum()
        {
            //Arrange
            Address address = new Address("street", "city", "province", "postalCode");
            Swimmer aSwimmer = new Swimmer("name", new DateTime(2000, 1, 1), address, 1234567890);

            //Act

            //Assert
            Assert.AreEqual(aSwimmer.Name, "name");
            Assert.AreEqual(new DateTime(2000, 1, 1), aSwimmer.DateOfBirth);
            Assert.AreEqual(aSwimmer.Address, address);
            Assert.AreEqual(aSwimmer.PhoneNumber, 1234567890);
        }

        [TestMethod]
        public void Swimmer_WithIDNameAddressAndPhoneNumberarameter_ShouldHaveIDNameAddressPhoneNumberClub()
        {
            //Arrange
            Club aClub = new Club();
            Address address = new Address("street", "city", "province", "postalCode");
            Swimmer aSwimmer = new Swimmer(6, "name", new DateTime(2000, 1, 1), address, 1234567890);

            //Act

            //Assert
            Assert.AreEqual(aSwimmer.IdNum, 6);
            Assert.AreEqual(aSwimmer.Name, "name");
            Assert.AreEqual(new DateTime(2000, 1, 1), aSwimmer.DateOfBirth);
            Assert.AreEqual(aSwimmer.Address, address);
            Assert.AreEqual(aSwimmer.PhoneNumber, 1234567890);
        }

        [TestMethod]
        public void Swimmer_WithIDNameAddressAndPhoneNumberClubParameter_ShouldHaveIDNameAddressPhoneNumberClub()
        {
            //Arrange
            Club aClub = new Club();
            Address address = new Address("street", "city", "province", "postalCode");
            Swimmer aSwimmer = new Swimmer(5, "name", new DateTime(2000, 1, 1), address, 1234567890, aClub);

            //Act

            //Assert
            Assert.AreEqual(aSwimmer.IdNum, 5);
            Assert.AreEqual(aSwimmer.Name, "name");
            Assert.AreEqual(new DateTime(2000, 1, 1), aSwimmer.DateOfBirth);
            Assert.AreEqual(aSwimmer.Address, address);
            Assert.AreEqual(aSwimmer.PhoneNumber, 1234567890);
            Assert.AreEqual(aSwimmer.Club, aClub);
        }

        [TestMethod]
        public void Club_SetNewClub_ShouldSetClub()
        {
            //Arrange
            Club aClub = new Club();
            Swimmer aSwimmer = new Swimmer();
            aSwimmer.Club = aClub;

            //Act

            //Assert
            Assert.AreEqual(aClub, aSwimmer.Club);
        }

        [TestMethod]
        public void Club_SetClubAlreadyExists_ShouldThrowException()
        {
            //Arrange
            Club aClub = new Club();
            Swimmer aSwimmer = new Swimmer(5, "name", new DateTime(2000, 1, 1), new Address(), 1234567890, aClub);

            //Act

            //Assert
            try
            {
                aSwimmer.Club = new Club(); ;
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "Swimmer already registered");
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void AddCoach_SwimmerHasNoClub_ShouldReturnException()
        {
            //Arrange
            Swimmer aSwimmer = new Swimmer();
            Coach aCoach = new Coach();
            aCoach.Club = new Club();

            //Act
            try
            {
                aSwimmer.AddCoach(aCoach);
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
        public void AddCoach_CoachHasNoClub_ShouldReturnException()
        {
            //Arrange
            Swimmer aSwimmer = new Swimmer();          
            Coach aCoach = new Coach();
            aSwimmer.Club = new Club();

            //Act
            try
            {
                aSwimmer.AddCoach(aCoach);
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
        public void AddCoach_CoachAndSwimmerHasDiffClubs_ShouldReturnException()
        {
            //Arrange
            Swimmer aSwimmer = new Swimmer();
            Coach aCoach = new Coach();
            aSwimmer.Club = new Club("aClub");
            aCoach.Club = new Club("bClub");

            //Act
            try
            {
                aSwimmer.AddCoach(aCoach);
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
        public void AddCoach_CoachAndSwimmerHasSameClub_ShouldAddCoach()
        {
            //Arrange
            Club aClub = new Club();
            Swimmer aSwimmer = new Swimmer();
            Coach aCoach = new Coach();
            aSwimmer.Club = aClub;
            aCoach.Club = aClub;

            //Act
            aSwimmer.AddCoach(aCoach);


            //Assert
            Assert.AreEqual(aSwimmer.Club, aClub);
        }

        [TestMethod]
        public void AddAsBestTime_WithNoPreviousTime_ShouldAddTime()
        {
            //Arrange
            Swimmer aSwimmer = new Swimmer();
            TimeSpan time = TimeSpan.Parse("0:0:3:2.01");

            //Act
            aSwimmer.AddAsBestTime(PoolType.LCM, Stroke.Backstroke, EventDistance._100, time);

            //Assert
            Assert.AreEqual(aSwimmer.BestTimes[(int)(PoolType.LCM), (int)(Stroke.Backstroke), (int)(EventDistance._100)], time);
        }

        [TestMethod]
        public void AddAsBestTime_WithPreviousLonger_ShouldAddTime()
        {
            //Arrange
            Swimmer aSwimmer = new Swimmer();
            TimeSpan oldTime = TimeSpan.Parse("0:0:3:2.01");
            TimeSpan newTime = TimeSpan.Parse("0:0:2:2.01");
            aSwimmer.AddAsBestTime(PoolType.LCM, Stroke.Backstroke, EventDistance._100, oldTime);

            //Act
            aSwimmer.AddAsBestTime(PoolType.LCM, Stroke.Backstroke, EventDistance._100, newTime);

            //Assert
            Assert.AreEqual(aSwimmer.BestTimes[(int)(PoolType.LCM), (int)(Stroke.Backstroke), (int)(EventDistance._100)], newTime);
        }

        [TestMethod]
        public void AddAsBestTime_WithNewLonger_ShouldNotAddTime()
        {
            //Arrange
            Swimmer aSwimmer = new Swimmer();
            TimeSpan oldTime = TimeSpan.Parse("0:0:2:2.01");
            TimeSpan newTime = TimeSpan.Parse("0:0:3:2.01");
            aSwimmer.AddAsBestTime(PoolType.LCM, Stroke.Backstroke, EventDistance._100, oldTime);

            //Act
            aSwimmer.AddAsBestTime(PoolType.LCM, Stroke.Backstroke, EventDistance._100, newTime);

            //Assert
            Assert.AreEqual(aSwimmer.BestTimes[(int)(PoolType.LCM), (int)(Stroke.Backstroke), (int)(EventDistance._100)], oldTime);
        }

        [TestMethod]
        public void GetBestTime_WithNoPreviousTime_ShouldReturnException()
        {
            //Arrange
            Swimmer aSwimmer = new Swimmer();

            //Act
            try
            {
                aSwimmer.GetBestTime(PoolType.LCM, Stroke.Backstroke, EventDistance._100);
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "does not have a best time for this type of swim");
                return;
            }
            //Assert
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        public void GetBestTime_WithNreviousTime_ShouldReturnTime()
        {
            //Arrange
            Swimmer aSwimmer = new Swimmer();
            TimeSpan time = TimeSpan.Parse("0:0:3:2.01");


            //Act
            aSwimmer.AddAsBestTime(PoolType.LCM, Stroke.Backstroke, EventDistance._100, time);

            //Assert
            Assert.AreEqual(aSwimmer.GetBestTime(PoolType.LCM, Stroke.Backstroke, EventDistance._100), time);
        }
    }
}
