using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimModel
{
    [Serializable]
    public class Coach : Registrant
    {       
        public string Credentials { get; set; }
        public List<Swimmer> SwimmersList { get; private set; }
        public Coach() : this("", new DateTime(), new Address(), 0) { }

        public Coach(string name) : this(name, new DateTime(), new Address(), 0) { }
        public Coach(string name, DateTime dateOfBirth, Address address, long tele) : base(name, dateOfBirth, address, tele)
        {
            SwimmersList = new List<Swimmer>();
        }

        public Coach(string name, DateTime dateOfBirth, Address address, long tele, string credentials) :this(name, dateOfBirth, address, tele)
        {
            Credentials = credentials;
        }

        public Coach(string name, DateTime dateOfBirth, Address address, long tele, Club club, string credentials) : this(name, dateOfBirth, address, tele, credentials)
        {
            club.AddCoach(this);
        }

        public override Club Club
        {
            get
            {
                return club;
            }
            set
            {
                if (value == null)
                {
                    if (this.Club.CoachList.Contains(this))
                    {
                        this.Club.CoachList.Remove(this);
                        club = null;
                    }
                    else
                    {
                        throw new Exception($"Coach {Name} is not registered with club {this.Club.Name}");
                    }
                }
                else if (value.CoachList.Contains(this))
                {
                    throw new Exception($"Coach {Name} is already registered to this club!");
                }
                else if (club == null)
                {                    
                    club = value;
                    value.CoachList.Add(this);                  
                }             
                else
                {
                    throw new Exception($"Coach already registered to {Club.Name} club.");
                }
            }
        }

        public void AddSwimmer(Swimmer swimmer)
        {
            if (SwimmersList.Contains(swimmer))
            {
                throw new Exception($"Swimmer {swimmer.Name} is already taught by this coach!");
            }            
            try
            {
                swimmer.AddCoach(this);
            }
            catch (Exception)
            {
                throw;
            }
        }      

        public void RemoveSwimmer(Swimmer swimmer)
        {
            if (!SwimmersList.Contains(swimmer))
            {
                throw new Exception($"Swimmer {swimmer.Name} is not taught by this coach!");
            }
            try
            {
                swimmer.RemoveCoach(this);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string getStudentsInfo()
        {
            string studentList = "";
            foreach (var s in SwimmersList)
            {
                studentList += $"\n      {s.Name}";
            }
            return studentList;
        }
        public override string ToString()
        {
            return base.ToString() +
                   $"\nCredentials: {Credentials}" +
                   $"\nStudents: {getStudentsInfo()}";
        }
    }
}
