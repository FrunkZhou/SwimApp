using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimModel
{
    [Serializable]
    public class Swimmer : Registrant
    {
        private static int courses = Enum.GetNames(typeof(PoolType)).Length;
        private static int strokes = Enum.GetNames(typeof(Stroke)).Length;
        private static int distances = Enum.GetNames(typeof(EventDistance)).Length;

        private Coach coach;
        public TimeSpan[,,] BestTimes { get; set; }           

        public Swimmer() :this("", new DateTime(), new Address(), 0) { }
        public Swimmer(string name) :this(name, new DateTime(), new Address(), 0) { }
        public Swimmer(string name, DateTime dateOfBirth, Address address, long tele) :base(name, dateOfBirth, address, tele)
        {
            BestTimes = new TimeSpan[courses, strokes, distances];
        }

        public Swimmer(string name, DateTime dateOfBirth, Address address, long tele, Club club, Coach coach) :this(name, dateOfBirth, address, tele)
        {
            Club = club;
            Coach = coach;
        }

        public Swimmer(int id, string name, DateTime dateOfBirth, Address address, long tele) :this(name, dateOfBirth, address, tele)
        {
            IdNum = id;
        }

        public Swimmer(int id, string name, DateTime dateOfBirth, Address address, long tele, Club club) : this(id, name, dateOfBirth, address, tele)
        {
            Club = club;
        }

        public override Club Club
        {
            get { return club; }
            set
            {
                if (value == null)
                {
                    this.Club?.ClubMembers.Remove(this);
                    club = null;
                }
                else if (value.ClubMembers.Contains(this))
                {
                    throw new Exception($"Swimmer {Name} is already registered with club {value.Name}.");
                }               
                else if (club == null)
                {
                    club = value;
                    value.AddSwimmer(this);
                }
                else
                {
                    throw new Exception($"Swimmer already registered to {Club.Name} club.");
                }
            }
        }

        public Coach Coach
        {
            get
            {
                return coach;
            }
            set
            {
                if (value == null)
                {
                    if (this.Coach.SwimmersList.Contains(this))
                    {
                        this.Coach.SwimmersList.Remove(this);
                        coach = null;
                    }
                    else
                    {
                        throw new Exception($"Coach {Coach.Name} does not teach swimmer {Name}.");
                    }
                    return;
                }
                else if (value.SwimmersList.Contains(this))
                {
                    throw new Exception($"Swimmer {Name} is already registered to coach {value.Name}!");
                }
                else if (value?.Club == null)
                {
                    throw new Exception($"Coach {value.Name} does not belong to a club!");
                }
                else if (Club == null)
                {
                    throw new Exception($"Swimmer {Name} does not belong to a club!");
                }
                else if (this?.Club != value?.Club)
                {
                    throw new Exception($"Swimmer {Name} does not belong to the same club as coach {value.Name}!");
                }             
                coach = value;
                value.SwimmersList.Add(this);
            }
        }

        public TimeSpan GetBestTime(PoolType course, Stroke stroke, EventDistance distance)
        {
            if (BestTimes[(int)course, (int)stroke, (int)distance].Milliseconds == 0 && BestTimes[(int)course, (int)stroke, (int)distance].Seconds == 0 && BestTimes[(int)course, (int)stroke, (int)distance].Minutes == 0)
            {
                throw new Exception($"Swimmer {Name} does not have a best time for this type of swim.");
            }
            else
            {
                return BestTimes[(int)course, (int)stroke, (int)distance];
            }
        }

        public void AddAsBestTime(PoolType course, Stroke stroke, EventDistance distance, TimeSpan time)
        {
            if (TimeSpan.Compare(BestTimes[(int)course, (int)stroke, (int)distance], time) == 1 || TimeSpan.Equals(BestTimes[(int)course, (int)stroke, (int)distance], new TimeSpan()))
            {
                BestTimes[(int)course, (int)stroke, (int)distance] = time;
            }
        }

        public void AddCoach(Coach coach)
        {     
            try
            {
                Coach = coach;               
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void RemoveCoach(Coach coach)
        {
            try
            {
                Coach = null;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public override string ToString()
        {
            return base.ToString() + 
                   $"\nCoach: {Coach?.Name ?? "not assigned"}";
        }
    }
}
