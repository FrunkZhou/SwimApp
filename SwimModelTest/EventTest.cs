using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimModel;

namespace SwimModelTest
{
    [TestClass]
    public class EventTest
    {
        [TestMethod]
        public void EventConstructor_Paramaterless_ShouldHaveDistAndStrokeAsNone()
        {
            //Arrange
            Event anEvent = new Event();

            //Act           

            //Assert
            Assert.AreEqual(anEvent.Stroke, Stroke.None);
            Assert.AreEqual(anEvent.Distance, EventDistance.None);
        }

        [TestMethod]
        public void EventConstructor_WithStroke_ShouldHaveStrokeWithDistAsNone()
        {
            //Arrange
            Event anEvent = new Event(Stroke.Backstroke);

            //Act           

            //Assert
            Assert.AreEqual(anEvent.Stroke, Stroke.Backstroke);
            Assert.AreEqual(anEvent.Distance, EventDistance.None);
        }

        [TestMethod]
        public void EventConstructor_WithDist_ShouldHaveDistWithStrokeAsNone()
        {
            //Arrange
            Event anEvent = new Event(EventDistance._200);

            //Act           

            //Assert
            Assert.AreEqual(anEvent.Stroke, Stroke.None);
            Assert.AreEqual(anEvent.Distance, EventDistance._200);
        }

        [TestMethod]
        public void EventConstructor_WithDistThenStroke_ShouldHaveDistWithStroke()
        {
            //Arrange
            Event anEvent = new Event(EventDistance._200, Stroke.Butterfly);

            //Act           

            //Assert
            Assert.AreEqual(anEvent.Stroke, Stroke.Butterfly);
            Assert.AreEqual(anEvent.Distance, EventDistance._200);
        }

        [TestMethod]
        public void EventConstructor_WithStrokeThenDist_ShouldHaveStrokeWithDist()
        {
            //Arrange
            Event anEvent = new Event(Stroke.Butterfly, EventDistance._200);

            //Act           

            //Assert
            Assert.AreEqual(anEvent.Stroke, Stroke.Butterfly);
            Assert.AreEqual(anEvent.Distance, EventDistance._200);
        }

        [TestMethod]
        public void ToString_WithEventDistAndStroke_ShouldReturnEventDistAndStroke()
        {
            //Arrange
            Event anEvent = new Event(Stroke.Butterfly, EventDistance._200);

            //Act           

            //Assert
            StringAssert.Contains(anEvent.ToString(), "Butterfly");
            StringAssert.Contains(anEvent.ToString(), "_200");
        }

        [TestMethod]
        public void GetSwimmersListTestWithToString_SwimmerNotSeeded_ShouldReturnNotSeededMessage()
        {
            //Arrange
            Event anEvent = new Event();
            Swimmer Swimmer = new Swimmer("Bob");

            //Act           
            anEvent.AddSwimmer(Swimmer);

            //Assert
            StringAssert.Contains(anEvent.ToString(), "Not seeded/no swim");
        }

        [TestMethod]
        public void GetSwimmersListTestWithToString_2Swimmers_ShouldReturnSwimmerNames()
        {
            //Arrange
            Event anEvent = new Event();
            Swimmer swimmer1 = new Swimmer("Bob");
            Swimmer swimmer2 = new Swimmer("Alice");

            //Act           
            anEvent.AddSwimmer(swimmer1);
            anEvent.AddSwimmer(swimmer2);

            //Assert
            StringAssert.Contains(anEvent.ToString(), "Bob", "Did not return Swimmer [0]");
            StringAssert.Contains(anEvent.ToString(), "Alice", "Did not return Swimmer [1]");
        }

        [TestMethod]
        public void AddSwimmer_AddSameSwimmerTwice_ShouldThrowException()
        {
            //Arrange
            Event anEvent = new Event();
            Swimmer swimmer1 = new Swimmer("Bob");

            //Act           
            anEvent.AddSwimmer(swimmer1);
            

            //Assert
            try
            {
                anEvent.AddSwimmer(swimmer1);
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "Swimmer");
                StringAssert.Contains(e.Message, "already entered");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        public void AddSwimmer_Add1Swimmer_ShouldAddSwimmer()
        {
            //Arrange
            Event anEvent = new Event();
            Swimmer swimmer1 = new Swimmer("Bob");

            //Act      
            anEvent.AddSwimmer(swimmer1);

            //Assert      
            Assert.AreEqual(swimmer1, anEvent.SwimmersList[0]);
        }

        [TestMethod]
        public void AddSwimmer_Add2Swimmer_ShouldAdd2Swimmers()
        {
            //Arrange
            Event anEvent = new Event();
            Swimmer swimmer1 = new Swimmer("Bob");
            Swimmer swimmer2 = new Swimmer("Alice");

            //Act      
            anEvent.AddSwimmer(swimmer1);
            anEvent.AddSwimmer(swimmer2);

            //Assert      
            Assert.AreEqual(swimmer1, anEvent.SwimmersList[0]);
            Assert.AreEqual(swimmer2, anEvent.SwimmersList[1]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Seed_NegativeNumber_ShouldThrowException()
        {
            //Arrange
            Event anEvent = new Event();


            //Act      
            anEvent.Seed(-5);

            //Assert
        }

        [TestMethod]
        public void Seed_2SwimmersWith3Lanes_ShouldSeedAllSwimmers()
        {
            //Arrange
            Event anEvent = new Event();
            Swimmer swimmer1 = new Swimmer("Bob");
            Swimmer swimmer2 = new Swimmer("Alice");
            anEvent.AddSwimmer(swimmer1);
            anEvent.AddSwimmer(swimmer2);

            //Act      
            anEvent.Seed(3);

            //Assert
            Assert.AreEqual(1, anEvent.Swim[0].Heat);
            Assert.AreEqual(1, anEvent.Swim[0].Lane);
            Assert.AreEqual(1, anEvent.Swim[1].Heat);
            Assert.AreEqual(2, anEvent.Swim[1].Lane);
        }

        [TestMethod]
        public void Seed_4SwimmersWith3Lanes_ShouldSeedAllSwimmers()
        {
            //Arrange
            Event anEvent = new Event();
            Swimmer swimmer1 = new Swimmer();
            Swimmer swimmer2 = new Swimmer();
            Swimmer swimmer3 = new Swimmer();
            Swimmer swimmer4 = new Swimmer();
            anEvent.AddSwimmer(swimmer1);
            anEvent.AddSwimmer(swimmer2);
            anEvent.AddSwimmer(swimmer3);
            anEvent.AddSwimmer(swimmer4);

            //Act      
            anEvent.Seed(3);

            //Assert
            Assert.AreEqual(1, anEvent.Swim[0].Heat);
            Assert.AreEqual(1, anEvent.Swim[0].Lane);
            Assert.AreEqual(1, anEvent.Swim[1].Heat);
            Assert.AreEqual(2, anEvent.Swim[1].Lane);
            Assert.AreEqual(1, anEvent.Swim[2].Heat);
            Assert.AreEqual(3, anEvent.Swim[2].Lane);
            Assert.AreEqual(2, anEvent.Swim[3].Heat);
            Assert.AreEqual(1, anEvent.Swim[3].Lane);
        }

        [TestMethod]
        public void EnterSwimmersTime_SwimmerNotInEvent_ShouldThrowException()
        {
            //Arrange
            Event anEvent = new Event();
            Swimmer swimmer1 = new Swimmer();

            //Act      

            //Assert
            try
            {
                anEvent.EnterSwimmersTime(swimmer1, "1:02:03");
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "Swimmer");
                StringAssert.Contains(e.Message, "has not entered");
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void EnterSwimmersTime_InvalidTimeParseFormat_ShouldThrowFormatException()
        {
            //Arrange
            Event anEvent = new Event();
            Swimmer swimmer1 = new Swimmer();
            anEvent.AddSwimmer(swimmer1);
            anEvent.Seed(2);

            //Act      
            anEvent.EnterSwimmersTime(swimmer1, "abc");

            //Assert

        }

        [TestMethod]
        public void EnterSwimmersTime_Enter1SwimmersTime_ShouldAddSwimmersTime()
        {
            //Arrange
            Event anEvent = new Event();
            Swimmer swimmer1 = new Swimmer();
            anEvent.AddSwimmer(swimmer1);
            anEvent.Seed(2);

            //Act      
            anEvent.EnterSwimmersTime(swimmer1, "1:05.03");

            //Assert
            Assert.AreEqual(TimeSpan.Parse("0:0:1:05.03"), anEvent.Swim[0].SwimTime);
        }

        //[TestMethod]
        //public void EnterSwimmersTime_NotASwimmer_ShouldReturnException()
        //{
        //    //Arrange
        //    Event anEvent = new Event();
        //    Swimmer swimmer1 = new Swimmer();
        //    anEvent.AddSwimmer(swimmer1);
        //    anEvent.Seed(2);

        //    //Act      
        //    try
        //    {
        //        anEvent.EnterSwimmersTime(swimmer1, "1:05.03");
        //    }
        //    catch (Exception e)
        //    {
        //        StringAssert.Contains(e.Message, "not a Swimmer");
        //        return;
        //    }

        //    //Assert
        //    Assert.Fail("The expected exception was not thrown.");
        //}
    }
}
