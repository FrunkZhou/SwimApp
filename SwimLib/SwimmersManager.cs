using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SwimModel
{
    public class SwimmersManager : ISwimmersRepository
    {
        public List<Swimmer> Swimmers { get; set; }        
        public int Number { get; private set; }
        public ClubsManager ClubManager { get; set; }
        public SwimmersManager()
        {
            Swimmers = new List<Swimmer>();
            Number = 0;
        }

        public SwimmersManager(ClubsManager manager) :this ()
        {
            ClubManager = manager;
        }
        public void Add(Swimmer swimmer)
        {
            if (!Swimmers.Contains(swimmer))
            {
                Swimmers.Add(swimmer);
                Number++;
            }
            else
                throw new Exception($"This {swimmer.Name} swimmer already exists.");
        }
        public Swimmer GetByRegNum(int regNumber)
        { 
            for (int i = 0; i < Swimmers.Count; ++i)
            {
                if (Swimmers[i].IdNum == regNumber)
                    return Swimmers[i];
            }
            return null;
        }
        public void Load(string fileName, char delim)
        {
            FileStream inFile = null;
            StreamReader reader = null;
            string record;
            string[] fields;
            Swimmer tempSwimmer;
            try
            {
                inFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(inFile);
                record = reader.ReadLine();
                while (record != null)
                {
                    fields = record.Split(delim);
                    try
                    {
                        checkLoadedData(fields, record);
                            
                        tempSwimmer = new Swimmer(Convert.ToInt32(fields[0]), fields[1], Convert.ToDateTime(fields[2]), new Address(fields[3], fields[4], fields[5], fields[6]), Convert.ToInt64(fields[7]));
                        if (fields[8] != "")
                        {
                            tempSwimmer.Club = ClubManager.GetByRegNum(Convert.ToInt32(fields[8]));
                        }
                        Add(tempSwimmer);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    record = reader.ReadLine();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (inFile != null)
                    inFile.Close();
            }
        }
        public void Save(string fileName, char delim)
        {
            FileStream outFile = null;
            StreamWriter writer = null;
            try
            {
                outFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(outFile);
                foreach (var tempswimmer in Swimmers)
                {
                    writer.WriteLine(tempswimmer?.IdNum + delim + tempswimmer?.Name + delim + tempswimmer?.DateOfBirth.ToString() + delim +
                        tempswimmer?.Address.Street + delim + tempswimmer?.Address.City + delim + tempswimmer?.Address.Province + delim + tempswimmer?.Address.PostalCode +
                        tempswimmer?.PhoneNumber + delim + tempswimmer?.Club?.IdNum);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
                if (outFile != null)
                    outFile.Close();
            }
        }
        //public void Save(string fileName)
        //{
        //    FileStream outFile = null;
        //    BinaryFormatter bFormatter = new BinaryFormatter();
        //    try
        //    {
        //        outFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
        //        for (int i = 0; i < Number; ++i)
        //        { bFormatter.Serialize(outFile, Swimmers[i]); }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    finally
        //    {
        //        if (outFile != null)
        //            outFile.Close();
        //    }
        //}
        //public void Load(string fileName)
        //{
        //    FileStream inFile = null;
        //    BinaryFormatter bFormatter = new BinaryFormatter();
        //    Swimmer tempSwimmer;
        //    try
        //    {
        //        inFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        //        while (inFile.Position < inFile.Length)
        //        {
        //            tempSwimmer = (Swimmer)bFormatter.Deserialize(inFile);
        //            Add(tempSwimmer);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    finally
        //    {
        //        if (inFile != null)
        //            inFile.Close();
        //    }
        //}
        private void checkLoadedData(string[] fields, string record)
        {
            long output;
            // invalid registration number handling
            if (!(Int64.TryParse(fields[0], out output)))
            {
                throw new Exception($"Invalid swim record, registration number format is not valid: " +
                                    $"\n        {record}");
            }
            if (GetByRegNum(Convert.ToInt32(fields[0])) != null)
                throw new Exception($"Invalid swim record, swimmer with registration # {fields[0]} already exists: " +
                                    $"\n        {record}");
            // invalid empty name throwing
            if (fields[1] == "")
                throw new Exception($"Invalid swim record, swimmer name cannot be empty: " +
                                    $"\n        {record}");
            // invalid birthday throwing
            try
            {
                Convert.ToDateTime(fields[2]);
            }
            catch (FormatException)
            {
                throw new FormatException($"Invalid swim record, birth date format is wrong: " +
                                          $"\n        {record}");
            }
            // invalid phone number handling
            if (!(Int64.TryParse(fields[7], out output)))
            {
                throw new Exception($"Invalid club record, phone number format is not valid: " +
                                    $"\n        {record}");
            }
            if (Convert.ToString(fields[7]).Length != 10)
            {
                throw new FormatException($"Invalid club record, phone number is not 10 digits: " +
                                    $"\n        {record}");
            }         
        }
    }
}
