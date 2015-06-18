using LOLDotNet.LeagueDataModel.LeagueEntityObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLDotNet.LeagueDataModel.Inferfaces
{
    public interface IChampionService
    {
        ChampionCollection GetChampionCollection();
        ItemCollection GetItemCollection();
    }
}
