using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimModel;

namespace SwimModelTest
{
    [TestClass]
    public class SwimMeetTest
    {
        [TestMethod]
        public void SwimMeet_Parameterless_ShouldReturnEmptyNameDatesAndLCMType8Lanes()
        {
            //Arrange
            SwimMeet aSwimMeet = new SwimMeet();

            //Act

            //Assert
            Assert.AreEqual("", aSwimMeet.Name);
            Assert.AreEqual(PoolType.LCM, aSwimMeet.Course);
            Assert.AreEqual(8, aSwimMeet.NumberOfLanes);
        }

        [TestMethod]
        public void SwimMeet_WithProperParamters_ShouldConstructSwimMeetWithParameters()
        {
            //Arrange
            DateTime startTime = new DateTime(2000, 1, 2);
            DateTime endTime = new DateTime(2001, 2, 3);
            PoolType course = PoolType.SCM;
            int numberOfLanes = 3;
            string name = "Bob";

            //Act
            SwimMeet aSwimMeet = new SwimMeet(name, startTime, endTime, course, numberOfLanes);

            //Assert
            Assert.AreEqual(name, aSwimMeet.Name);
            Assert.AreEqual(startTime, aSwimMeet.StartDate);
            Assert.AreEqual(endTime, aSwimMeet.EndDate);
            Assert.AreEqual(course, aSwimMeet.Course);
            Assert.AreEqual(numberOfLanes, aSwimMeet.NumberOfLanes);
        }

        [TestMethod]
        public void GetEventListUsingToString_WithEvents_ShouldReturnListOfEvents()
        {
            //Arrange
            Event anEvent1 = new Event();
            Event anEvent2 = new Event();

            SwimMeet aSwimMeet = new SwimMeet();

            //Act
            aSwimMeet.AddEvent(anEvent1);
            aSwimMeet.AddEvent(anEvent2);

            //Assert
            StringAssert.Contains(aSwimMeet.ToString(), "None");
        }

        [TestMethod]
        public void ToString_WithConstructedInstance_ShouldReturnInfo()
        {
            //Arrange
            DateTime startTime = new DateTime(2000, 1, 2);
            DateTime endTime = new DateTime(2001, 2, 3);
            PoolType course = PoolType.SCM;
            int numberOfLanes = 3;
            string name = "Bob";

            //Act
            SwimMeet aSwimMeet = new SwimMeet(name, startTime, endTime, course, numberOfLanes);

            //Assert
            StringAssert.Contains(aSwimMeet.ToString(), "Swim meet name: Bob", "Did not return name");
            StringAssert.Contains(aSwimMeet.ToString(), "2000-01-02", "Did not return startDate");
            StringAssert.Contains(aSwimMeet.ToString(), "2001-02-03", "Did not return endDate");
            StringAssert.Contains(aSwimMeet.ToString(), "Pool type: SCM", "Did not return course");
            StringAssert.Contains(aSwimMeet.ToString(), "# of Lanes: 3", "Did not reutrn name");
        }

        [TestMethod]
        public void AddEvent_With1Event_ShouldAddEvent()
        {
            //Arrange
            Event anEvent = new Event();
            SwimMeet aSwimMeet = new SwimMeet();

            //Act
            aSwimMeet.AddEvent(anEvent);

            //Assert
            Assert.AreEqual(anEvent, aSwimMeet.Events[0]);
        }

        [TestMethod]
        public void Seed_WithProperValues_ShouldProperlySeed()
        {
            //Arrange
            Event anEvent = new Event();
            Swimmer swimmer1 = new Swimmer("Bob");
            Swimmer swimmer2 = new Swimmer("Alice");
            Swimmer swimmer3 = new Swimmer("Charlie");
            SwimMeet aSwimMeet = new SwimMeet("Meet", new DateTime(), new DateTime(), PoolType.LCM, 2);
            anEvent.AddSwimmer(swimmer1);
            anEvent.AddSwimmer(swimmer2);
            anEvent.AddSwimmer(swimmer3);
            aSwimMeet.AddEvent(anEvent);

            //Act
            aSwimMeet.Seed();

            //Assert
            Assert.AreEqual(1, aSwimMeet.Events[0].Swim[0].Heat);
            Assert.AreEqual(1, aSwimMeet.Events[0].Swim[0].Lane);
            Assert.AreEqual(1, aSwimMeet.Events[0].Swim[1].Heat);
            Assert.AreEqual(2, aSwimMeet.Events[0].Swim[1].Lane);
            Assert.AreEqual(2, aSwimMeet.Events[0].Swim[2].Heat);
            Assert.AreEqual(1, aSwimMeet.Events[0].Swim[2].Lane);
        }

        [TestMethod]
        public void AddEvent_WithCourseType_ShouldSetCourseTypeForEvent()
        {
            //Arrange
            Event anEvent = new Event();
            SwimMeet aSwimMeet = new SwimMeet("Meet", new DateTime(), new DateTime(), PoolType.LCM, 2);


            //Act
            aSwimMeet.AddEvent(anEvent);

            //Assert
            Assert.AreEqual(PoolType.LCM, anEvent.Course);

        }
    }
}
