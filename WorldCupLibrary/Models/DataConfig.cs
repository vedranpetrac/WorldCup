using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCupLibrary.Models
{
    [Serializable]
    public enum Culture
    {
        en,hr
    }
    [Serializable]
    public enum TeamGender
    {
        male,female
    }
    [Serializable]
    public class DataConfig
    {   

        public Culture Culture { get; set; }
     
        public TeamGender TeamGender { get; set; }
    }
}
