using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCupLibrary.Models
{
    public enum Culture
    {
        en,hr
    }

    public enum TeamGender
    {
        male,female
    }

    public class DataConfig
    {
        public Culture Culture { get; set; }
        public TeamGender TeamGender { get; set; }
    }
}
