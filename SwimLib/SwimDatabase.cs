using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimModel
{
    [Serializable]
    public class SwimDatabase
    {
        public List<Club> Clubs { get; set; }
        public List<Swimmer> Swimmers { get; set; }
        public List<Coach> Coaches { get; set; }
        public List<SwimMeet> SwimMeets { get; set; }

        public SwimDatabase()
        {
            Clubs = new List<Club>();
            Swimmers = new List<Swimmer>();
            Coaches = new List<Coach>();
            SwimMeets = new List<SwimMeet>();
        }
    }
}
