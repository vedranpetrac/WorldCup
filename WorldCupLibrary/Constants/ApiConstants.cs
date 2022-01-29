using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCupLibrary.Constants
{
    class ApiConstants
    {
        public const string WOMEN_RESULTS_ENDPOINT = "http://worldcup.sfg.io/teams/results";
        public const string WOMEN_MATCHES_ENDPOINT = "http://worldcup.sfg.io/matches";
        public const string WOMEN_MATCH_ENDPOINT = "http://worldcup.sfg.io/matches/country?fifa_code=";

        public const string MEN_RESULTS_ENDPOINT = "http://world-cup-json-2018.herokuapp.com/teams/results";
        public const string MEN_MATCHES_ENDPOINT = "http://world-cup-json-2018.herokuapp.com/matches/";
        public const string MEN_MATCH_ENDPOINT = "http://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";


    }
}
