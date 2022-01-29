using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldCupLibrary.Dal.WorldCupDataSource;

namespace WorldCupLibrary.Dal
{
    public static class WorldCupDataFactory
    {
       
        public static IRepoWorldCupData GetData => new OnlineSource();
    }
}
