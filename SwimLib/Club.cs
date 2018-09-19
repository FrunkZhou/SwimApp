using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimModel
{
    [Serializable]
    public class Club
    {
        private static int idCount = 1;
        private long phoneNumber;
        public string Name { get; set; }
        public int IdNum { get; private set; }
        public Address Address { get; set; }
        public List<Coach> CoachList { get; private set; }
        public List<Swimmer> ClubMembers { get; private set; }
       
        public Club() : this("", new Address(), 0) { }
        public Club(string name) : this(name, new Address(), 0) { }
        public Club(string name, Address address) : this(name, address, 0) { }
        public Club(string name, Address address, long tele)
        {
            IdNum = idCount++;
            Name = name;
            Address = address;
            ClubMembers = new List<Swimmer>();
            CoachList = new List<Coach>();
            PhoneNumber = tele;
        }
        public Club(int id, string name, Address address, long tele) :this(name, address, tele)
        {
            IdNum = id;
        }
        
        public long PhoneNumber
        {
            get { return phoneNumber; }

            set
            {
                if (Convert.ToString(value).Length != 10 && value != 0)
                { throw new ArgumentException("Invalid phone number."); }
                else
                {  phoneNumber = value; }
            }
        }       
            
        private string getCoachList()
        {
            string list = "";
            foreach (var coach in CoachList)
            {
                list += $"\n          {coach.Name}";
            }
            return list;
        }

        private string getPhoneInfo()
        {
            if (PhoneNumber == 0)
            { return "not assigned"; }
            else
            { return Convert.ToString(PhoneNumber); }
        }

        private string getRegistrantsList()
        {
            string registrantsList = "";
            foreach (var registrant in ClubMembers)
            {
                registrantsList += $"\n          {registrant.Name}";
            }
            return registrantsList;
        }

        public void AddSwimmer(Swimmer swimmer)
        {
            if (!ClubMembers.Contains(swimmer) && swimmer.Club == this)
            {
                ClubMembers.Add(swimmer);
                return;
            }        
            try
            {
                swimmer.Club = this;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void RemoveSwimmer(Swimmer swimmer)
        {
            if (ClubMembers.Contains(swimmer))
            {
                try
                {
                    swimmer.Club = null;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                throw new Exception($"Swimmer {swimmer.Name} is not in club {Name}.");
            }
        }

        public void AddCoach(Coach coach)
        {
            try
            {
                coach.Club = this;
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
                coach.Club = null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}" +
                   $"\nAddress:\n{Address.ToString()}" +
                   $"\nPhone: {getPhoneInfo()}" +
                   $"\nReg Number: {IdNum}" +
                   $"\nSwimmers: {getRegistrantsList()}" +
                   $"\nCoaches: {getCoachList()}";
        }
    }
}
