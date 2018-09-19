using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimModel
{
    [Serializable]
    public class Registrant
    {
        private static int idCount = 1;
        protected Club club;
        private long phoneNumber;
        public static int IdCount { get; private set; }
        public int IdNum { get; protected set; }
        public string Name { get; set; }
        public Address Address { get; set; }
       
        public Registrant() : this("", new DateTime(), new Address(), 0) { }
        public Registrant(string name) : this(name, new DateTime(), new Address(), 0) { }
        public Registrant(string name, DateTime dateOfBirth) : this(name, dateOfBirth, new Address(), 0) { }
        public Registrant(string name, DateTime dateOfBirth, Address address) : this(name, dateOfBirth, address, 0) { }
        public Registrant(string name, DateTime dateOfBirth, Address address, long tele)
        {
            IdNum = idCount++;
            Name = name;
            DateOfBirth = dateOfBirth;
            Address = address;
            PhoneNumber = tele;
        }
        public Registrant(string name, DateTime dateOfBirth, Address address, long tele, Club club) :this(name, dateOfBirth, address, tele)
        {
            Club = club;
        }
        public Registrant(int id, string name, DateTime dateOfBirth, Address address, long tele) : this(name, dateOfBirth, address, tele)
        {
            IdNum = id;
        }

        public Registrant(int id, string name, DateTime dateOfBirth, Address address, long tele, Club club) :this(id, name, dateOfBirth, address, tele)
        {
            Club = club;
        }
        
        public long PhoneNumber
        {
            get { return phoneNumber; }

            set
            {
                if (Convert.ToString(value).Length != 10 && value != 0)
                { throw new ArgumentException("Invalid phone number."); }
                else
                { phoneNumber = value; }
            }
        }
        public DateTime DateOfBirth { get; set; }
        public virtual Club Club
        {
            get { return club; }
            set
            {
                if (value.ClubMembers.Contains(this))
                {
                    throw new Exception($"Registrant {Name} is already registered with club {value.Name}.");
                }
                else if (club == null)
                {
                    club = value;
                }
                else
                {
                    throw new Exception($"Registrant already registered to {Club.Name} club.");
                }
            }
        }
        
        private string getPhoneInfo()
        {
            if (PhoneNumber == 0)
            { return "not assigned"; }
            else
                return Convert.ToString(PhoneNumber);
        }

        public override string ToString()
        {
            return $"Name: {Name}" +
                   $"\nAddress:\n{Address.ToString()}" +
                   $"\nPhone: {getPhoneInfo()}" +
                   $"\nDOB: {DateOfBirth.ToString("yyyy\\-MM\\-dd")}" +
                   $"\nReg Number: {IdNum}" +
                   $"\nClub: {Club?.Name ?? "not assigned"}";
        }
    }
}
