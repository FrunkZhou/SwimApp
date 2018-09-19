using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SwimModel
{
    public class ClubsManager : IClubsRepository
    {
        public List<Club> Clubs { get; set; }
        public int Number { get; private set; }
        public ClubsManager()
        {
            Clubs = new List<Club>();
            Number = 0;
        }

        public void Add(Club club)
        {
            if (!Clubs.Contains(club))
            {
                Clubs.Add(club);
                Number++;
            }
            else
                throw new Exception($"This {club.Name} club already exists.");
        }

        public Club GetByRegNum(int regNumber)
        {
            for (int i = 0; i < Clubs.Count; ++i)
            {
                if (Clubs[i].IdNum == regNumber)
                    return Clubs[i];
            }
            return null;
        }

        public void Load(string fileName, char delim)
        {
            FileStream inFile = null;
            StreamReader reader = null;
            string record;
            string[] fields;
            Club tempClub;
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
                        tempClub = new Club(Convert.ToInt32(fields[0]), fields[1], new Address(fields[2], fields[3], fields[4], fields[5]), Convert.ToInt64(fields[6]));
                        Add(tempClub);
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
                foreach (var tempclub in Clubs)
                {
                    writer.WriteLine(tempclub.IdNum + delim + tempclub.Name + delim + tempclub.Address.Street + delim +
                        tempclub.Address.City + delim + tempclub.Address.Province + delim + tempclub.Address.PostalCode +
                        tempclub.PhoneNumber);
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
        //        { bFormatter.Serialize(outFile, Clubs[i]); }
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
        //    Club tempClub;
        //    try
        //    {
        //        inFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        //        while (inFile.Position < inFile.Length)
        //        {
        //            tempClub = (Club)bFormatter.Deserialize(inFile);
        //            Add(tempClub);
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
                throw new Exception($"Invalid club record, registration number format is not valid: " +
                                    $"\n        {record}");
            }
            if (GetByRegNum(Convert.ToInt32(fields[0])) != null)
                throw new Exception($"Invalid club record, club with registration #{fields[0]} already exists: " +
                                    $"\n        {record}");
            // invalid empty name throwing
            if (fields[1] == "")
                throw new Exception($"Invalid club record, club name cannot be empty: " +
                                    $"\n        {record}");
            // invalid phone number handling
            if (!(Int64.TryParse(fields[6], out output)))
            {
                throw new Exception($"Invalid club record, phone number format is not valid: " +
                                    $"\n        {record}");
            }
            
        }
    }
}
