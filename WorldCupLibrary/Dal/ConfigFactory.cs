using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using WorldCupLibrary.Models;
using WorldCupLibrary.Models.Match;
using WorldCupLibrary.Models.Nation;

namespace WorldCupLibrary.Dal
{


    public class ConfigFactory
    {
        private string DIR = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private string FILE = @"\config.txt";


        public bool CheckDataConfig()
        {

                if (!File.Exists(DIR + FILE))
                {
                    return false;
                }
                return true;

        }

        public DataConfig LoadDataConfig()
        {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(DIR + FILE, FileMode.Open, FileAccess.Read);
                DataConfig dataConfig = new DataConfig();
                dataConfig = (DataConfig)formatter.Deserialize(stream);
                stream.Close();
                return dataConfig;         
        }

        public Nation LoadFavNation()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(DIR + FILE, FileMode.Open, FileAccess.Read);
            Nation nation = new Nation();
            nation = (Nation)formatter.Deserialize(stream);
            stream.Close();
            return nation;
        }

        public void SaveDataConfig(DataConfig dataConfig)
        {

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(DIR + FILE, FileMode.Create, FileAccess.Write);

                formatter.Serialize(stream, dataConfig);
                stream.Close();

        }

        public void SaveFavNation(Nation nation)
        {
            
            
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(DIR + FILE, FileMode.Create, FileAccess.Write);

                formatter.Serialize(stream, nation);
                stream.Close();
           
        }

       
    }
}
