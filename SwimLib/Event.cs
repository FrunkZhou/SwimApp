using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimModel
{
    public enum EventDistance
    {
        None,
        _50,
        _100,
        _200,
        _400,
        _800,
        _1500,
    };

    public enum Stroke
    {
        None,        
        Backstroke,
        Breaststroke,
        Butterfly,
        Freestyle,
        Individual_Medley
    };

    [Serializable]
    public class Event
    {
        public EventDistance Distance { get; set; }
        public Stroke Stroke { get; set; }
        public List<Swimmer> SwimmersList { get; private set; }
        public List<Swim> Swim { get; private set; }
        public PoolType Course { get; set; }
        public Event() : this(Stroke.None, EventDistance.None) { }
        public Event(EventDistance dist) : this(Stroke.None, dist) { }
        public Event(Stroke type) : this(type, EventDistance.None) { }
        public Event(EventDistance dist, Stroke type) : this(type, dist) { }       
        public bool IsSeeded { get; private set; }
        public Event(Stroke type, EventDistance dist)
        {
            Distance = dist;
            Stroke = type;
            SwimmersList = new List<Swimmer>();
            Swim = new List<Swim>();
            IsSeeded = false;
        }
        
        private string getSwimmersList()
        {
            string swimmersList = "";
            for (int i = 0; i < SwimmersList.Count; i++)
            {
                swimmersList += $"        {SwimmersList[i].Name,-22}";
                if (Swim.Count > i)
                {
                    swimmersList += $"{Swim[i].ToString()}";
                }
                else
                {
                    swimmersList += $"\n                Not seeded/no swim\n";
                }
            }
            return swimmersList;
        }

        public void AddSwimmer(Swimmer swimmer)
        {
            if (SwimmersList.Contains(swimmer))
            { throw new Exception($"Swimmer {swimmer.Name} with registration number {swimmer.IdNum} is already entered."); }
            SwimmersList.Add(swimmer);
            Swim.Add(new Swim());
        }
        public void Seed(int numOfLanes)
        {
            if (IsSeeded)
            {
                return;
            }
            if (numOfLanes < 0)
            { throw new ArgumentException("Number of lanes cannot be less than zero!"); }
            int swimIndex = 0;
            int totalHeats = (SwimmersList.Count / numOfLanes) + 1;
            for (int heat = 1; heat <= totalHeats; ++heat)
            {
                for (int lane = 1; lane <= numOfLanes; ++lane)
                {
                    if (swimIndex < SwimmersList.Count)
                    {
                        Swim[swimIndex].Lane = lane;
                        Swim[swimIndex].Heat = heat;
                        swimIndex++;
                    }
                }
            }
            IsSeeded = true;
        }
        public void EnterSwimmersTime(Swimmer swimmer, string time)
        {
            if (!SwimmersList.Contains(swimmer))
                throw new Exception($"Swimmer {swimmer.Name} has not entered the {Distance} {Stroke} event.");
            // Finds the index of the registrant 
            int swimmerIndex = 0;
            foreach (var aregistrant in SwimmersList)
            {
                if (aregistrant == swimmer)
                {
                    break;
                }
                swimmerIndex++;
            }
            try
            {
                Swim[swimmerIndex].SwimTime = TimeSpan.Parse("0:0:" + time);
                swimmer.AddAsBestTime(Course, Stroke, Distance, TimeSpan.Parse("0:0:" + time));
            }
            catch (FormatException)
            {
                throw;
            }
            catch (InvalidCastException)
            {
                Console.WriteLine($"Registrant {swimmer.Name} is not an actual swimmer!");
            }
        }
        public override string ToString()
        {
            return $"\n        {Distance} {Stroke}" +
                   $"\n        Swimmers: " +
                   $"\n{(getSwimmersList())}";
        }
    }
}
