using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimModel
{
    public interface ISwimmersRepository
    {
        int Number { get; }
        void Add(Swimmer swimmer);
        void Load(string fileName, char delim);
        void Save(string fileName, char delim);
        Swimmer GetByRegNum(int regNum);
    }
}
