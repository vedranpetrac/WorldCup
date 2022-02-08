using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldCupLibrary.Models;
using WorldCupLibrary.Models.Match;


namespace WorldCupLibrary.Dal
{
    public interface IRepoWorldCupData
    {
       
        Task<List<Nation>> GetNations(TeamGender teamGenderType);
        Task<List<Match>> GetMatches(Nation nation, TeamGender teamGenderType);
    }
}
