using LOLDotNet.LeagueDataModel.Inferfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLDotNet.LeagueLibraryServer.Services
{
    public class ServiceManager : IServiceProvider
    {
        public object GetService(Type serviceType)
        {
            object result = null;
            if(serviceType == typeof(IChampionService))
            {
                result = new ChampionService();
            }
            return result;
        }
    }
}
