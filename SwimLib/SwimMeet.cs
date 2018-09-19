using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimModel
{  
    public enum PoolType
    {
        None,
        SCM,
        SCY,
        LCM
    };

    [Serializable]
    public class SwimMeet
    {
        public string Name { get; set; }
        public PoolType Course { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NumberOfLanes { get; private set; }
        public List<Event> Events { get; set; }

        public SwimMeet() : this("", new DateTime(), new DateTime(), PoolType.LCM, 8) { }
        //public SwimMeet(DateTime startDate) : this(startDate, new DateTime(), "No name entered", POOL_TYPE.SCM) { }
        //public SwimMeet(DateTime startDate, DateTime endDate) : this(startDate, endDate, "No name entered", POOL_TYPE.SCM) { }
        //public SwimMeet(DateTime startDate, DateTime endDate, string name) : this(startDate, endDate, name, POOL_TYPE.SCM) { }
        //public SwimMeet(DateTime startDate, DateTime endDate, string name, POOL_TYPE course) : this(startDate, endDate, name, POOL_TYPE.SCM, 8) { }
        public SwimMeet(string name, DateTime startDate, DateTime endDate, PoolType course, int noOfLanes)
        {
            StartDate = startDate;
            EndDate = endDate;
            Name = name;
            Course = course;
            NumberOfLanes = noOfLanes;
            Events = new List<Event>();
        }
       
        private string getEventsList()
        {
            string eventsList = "";
            foreach (var anEvent in Events)
            {
                eventsList += $"{anEvent.ToString()}";
            }
            return eventsList;
        }

        public void AddEvent(Event swimEvent)
        {
            swimEvent.Course = Course;
        }

        public void Seed()
        {
            for (int i = 0; i < Events.Count; ++i)
            {
                Events[i].Seed(NumberOfLanes);
            }
        }
        public override string ToString()
        {
            return $"Swim meet name: {Name}" +
                   $"\nFrom-to: {StartDate.ToString("yyyy\\-MM\\-dd")} to {EndDate.ToString("yyyy\\-MM\\-dd")}" +
                   $"\nPool type: {Course}" +
                   $"\n# of Lanes: {NumberOfLanes}" +
                   $"\nEvents: {getEventsList()}";
        }
    }
}
