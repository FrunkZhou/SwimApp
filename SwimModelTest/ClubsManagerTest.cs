using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimModel;

namespace SwimModelTest
{
    [TestClass]
    public class ClubsManagerTest
    {
        [TestMethod]
        public void ClubsManager_WithParamaterlessConstructor_ShouldCreateClubsManager()
        {
            //Arrange
            ClubsManager aMgr = new ClubsManager();

            //Act

            //Assert
            Assert.AreEqual(aMgr.Number, 0);
        }

        [TestMethod]
        public void Add_WithNewClub_ShouldAddClub()
        {
            //Arrange
            ClubsManager aMgr = new ClubsManager();
            Club aClub = new Club();

            //Act
            aMgr.Add(aClub);

            //Assert
            Assert.AreEqual(aMgr.Clubs[0], aClub);
        }

        [TestMethod]
        public void Add_SameClubTwice_ShouldReturnException()
        {
            //Arrange
            ClubsManager aMgr = new ClubsManager();
            Club aClub = new Club();
            aMgr.Add(aClub);

            //Act
            try
            {
                aMgr.Add(aClub);
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "club already exists");
                return;
            }

            //Assert
            Assert.Fail("The expected exception was not thrown");
        }

        [TestMethod]
        public void GetByRegNumber_WithRegNumberClubSame_ShouldReturnClub()
        {
            //Arrange
            ClubsManager aMgr = new ClubsManager();
            Club aClub = new Club(5, "", new Address(), 0);
            aMgr.Add(aClub);

            //Act
            Club gotClub = aMgr.GetByRegNum(5);

            //Assert
            Assert.AreEqual(aMgr.Clubs[0], gotClub);
        }

        [TestMethod]
        public void GetByRegNumber_WithRegNumberClubNotSame_ShouldReturnNull()
        {
            //Arrange
            ClubsManager aMgr = new ClubsManager();
            Club aClub = new Club(5, "", new Address(), 0);
            aMgr.Add(aClub);

            //Act
            Club gotClub = aMgr.GetByRegNum(4);

            //Assert
            Assert.IsNull(gotClub);
        }
    }
}
