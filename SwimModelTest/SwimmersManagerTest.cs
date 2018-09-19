using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimModel;

namespace SwimModelTest
{
    [TestClass]
    public class SwimmersManagerTest
    {
        [TestMethod]
        public void SwimmersManager_WithParamaterlessConstructor_ShouldCreateSwimmersManager()
        {
            //Arrange
            SwimmersManager aSMgr = new SwimmersManager();

            //Act

            //Assert
            Assert.AreEqual(aSMgr.Number, 0);
        }

        [TestMethod]
        public void SwimmersManager_WithClubManager_ShouldCreateSwimmersManager()
        {
            //Arrange
            ClubsManager aMgr = new ClubsManager();
            SwimmersManager aSMgr = new SwimmersManager(aMgr);

            //Act

            //Assert
            Assert.AreEqual(aSMgr.ClubManager, aMgr);
        }

        [TestMethod]
        public void Add_WithNewSwimmer_ShouldAddSwimmer()
        {
            //Arrange
            SwimmersManager aSMgr = new SwimmersManager();
            Swimmer aSwimmer = new Swimmer();

            //Act
            aSMgr.Add(aSwimmer);

            //Assert
            Assert.AreEqual(aSMgr.Swimmers[0], aSwimmer);
        }

        [TestMethod]
        public void Add_SameSwimmerTwice_ShouldReturnException()
        {
            //Arrange
            SwimmersManager aSMgr = new SwimmersManager();
            Swimmer aSwimmer = new Swimmer();
            aSMgr.Add(aSwimmer);

            //Act
            try
            {
                aSMgr.Add(aSwimmer);
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "swimmer already exists");
                return;
            }

            //Assert
            Assert.Fail("The expected exception was not thrown");
        }

        [TestMethod]
        public void GetByRegNumber_WithRegNumberSwimmerSame_ShouldReturnSwimmer()
        {
            //Arrange
            SwimmersManager aSMgr = new SwimmersManager();
            Swimmer aSwimmer = new Swimmer(5, "", new DateTime(), new Address(), 0);
            aSMgr.Add(aSwimmer);

            //Act
            Swimmer gotSwimmer = aSMgr.GetByRegNum(5);

            //Assert
            Assert.AreEqual(aSMgr.Swimmers[0], gotSwimmer);
        }

        [TestMethod]
        public void GetByRegNumber_WithRegNumberSwimmerNotSame_ShouldReturnNull()
        {
            //Arrange
            SwimmersManager aSMgr = new SwimmersManager();
            Swimmer aSwimmer = new Swimmer(5, "", new DateTime(), new Address(), 0);
            aSMgr.Add(aSwimmer);

            //Act
            Swimmer gotSwimmer = aSMgr.GetByRegNum(4);

            //Assert
            Assert.IsNull(gotSwimmer);
        }
    }
}
