using LOLDotNet.LeagueDataModel;
using LOLDotNet.LeagueDataAccess.DataAccess;
using LOLDotNet.LeagueDataModel.DataAccessObjects;
using LOLDotNet.LeagueDataModel.LeagueEntityObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLDotNet.LeagueDataAccess.DataAccess
{
    public class DataController
    {

        private ChampionCollection mChampions;
        public ChampionCollection ChampionCollection
        {
            get
            {
                //if (mChampions == null)
                //    mChampions = ChampionCollection.GetChampionCollection();
                return mChampions;
            }
        }

        public static readonly DataController DEFAULT = new DataController();

    }
}
