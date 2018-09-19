using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimModel
{
    [Serializable]
    public class Swim
    {
        private int heat;
        private int lane;
        public Swim() :this(0, 0) { }
        public TimeSpan SwimTime { get; set; }
        public Swim(int heat, int lane)
        {
            Heat = heat;
            Lane = lane;
        }

        public int Heat
        {
            get { return heat; }
            set
            {
                if (value < 0)
                { throw new ArgumentOutOfRangeException("Heat cannot be negative!"); }
                else { heat = value; }
            }
        }
        public int Lane
        {
            get { return lane; }
            set
            {
                if (value < 0)
                { throw new ArgumentOutOfRangeException("Lane cannot be negative!"); }
                else { lane = value; }
            }
        }
  
        public override string ToString()
        {
            if (Heat == 0 || Lane == 0)
            { return null; }
            else if (SwimTime.Minutes == 0 && SwimTime.Seconds == 0 && SwimTime.Milliseconds == 0)
            {
                return $"H{Heat}L{Lane}  time: no time\n";
            }
            else
            {
                return $"H{Heat}L{Lane}  time: {SwimTime.ToString("mm\\:ss\\:ff")}\n";
            }
        }
    }   
}
