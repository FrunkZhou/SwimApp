using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimModel;

namespace SwimModelTest
{
    [TestClass]
    public class SwimTest
    {
        [TestMethod]
        public void Swim_Parameterless_ShouldReturnHeadAndLaneAs0()
        {
            //Arrange
            Swim aSwim = new Swim();

            //Act

            //Assert
            Assert.AreEqual(0, aSwim.Heat);
            Assert.AreEqual(0, aSwim.Lane);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Heat_WithNegativeInteger_ShouldThrowArgumentOutOfRangeException()
        {
            //Arrange
            int heat = -5;
            Swim aSwim = new Swim();

            //Act
            aSwim.Heat = heat;

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Lane_WithNegativeInteger_ShouldThrowArgumentOutOfRangeException()
        {
            //Arrange
            int lane = -4;
            Swim aSwim = new Swim();

            //Act
            aSwim.Lane = lane;

            //Assert
        }

        [TestMethod]     
        public void ToString_WithNoHeatAndLane_ShouldReturnNull()
        {
            //Arrange
            Swim aSwim = new Swim();

            //Act

            //Assert
            Assert.IsNull(aSwim.ToString());
        }

        [TestMethod]
        public void ToString_With0Time_ShouldReturnNoTime()
        {
            //Arrange
            Swim aSwim = new Swim(1, 1);


            //Act
            aSwim.SwimTime = TimeSpan.Parse("0:0:0:0.0");

            //Assert
            StringAssert.Contains(aSwim.ToString(), "time: no time");
        }

        [TestMethod]
        public void ToString_WithProperTime_ShouldReturnTime()
        {
            //Arrange
            string time = "0:0:3:2.01";
            Swim aSwim = new Swim(1, 1);

            //Act
            aSwim.SwimTime = TimeSpan.Parse(time);

            //Assert
            StringAssert.Contains(aSwim.ToString(), "time: 03:02:01");
        }     
    }
}
