using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldCupLibrary.Models;
using WorldCupLibrary.Models.Match;

namespace WorldCupLibrary.Dal
{
    public interface IRepoConfig
    {
        Task<bool> CheckDataConfig();
        Task<DataConfig> LoadDataConfig();
        Task SaveDataConfig(DataConfig dataConfig);
        Task SavePlayers(StartingEleven players);
        Task<StartingEleven> LoadPlayers(string nationCode);


    }
}
