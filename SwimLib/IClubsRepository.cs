using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimModel
{
    public interface IClubsRepository
    {
        int Number { get; }
        void Add(Club club);
        void Load(string fileName, char delim);
        void Save(string fileName, char delim);
        Club GetByRegNum(int regNum);
    }
}
