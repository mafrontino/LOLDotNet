using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOLDotNet.LeagueDataModel.Inferfaces;
using LOLDotNet.LeagueDataModel.DataAccessObjects;
using LOLDotNet.LeagueDataAccess.DataAccess;
using System.Configuration;
using LOLDotNet.LeagueDataModel;
using LOLDotNet.LeagueDataModel.LeagueEntityObjects;

namespace LOLDotNet.LeagueLibraryServer.Services
{
    public class ChampionService : IChampionService
    {
        public ChampionCollection GetChampionCollection()
        {
            RequestData requestData = new RequestData();
            requestData.Region = "na";
            requestData.Version = "v1.2";
            requestData.UrlRequestType = UrlRequestType.ChampionStaticData;
            requestData.RequestType = RequestType.champion;
            requestData.ChampDataType = ChampDataType.all;

            if (ConfigurationManager.AppSettings.AllKeys.Contains<string>("APIKey"))
                requestData.APIKey = ConfigurationManager.AppSettings["APIKey"];

            //Get champion non-static info
            ChampionCollection result = WebRequestHelper.DoRequest<ChampionCollection>(requestData);

            requestData.ChampDataType = ChampDataType.None;
            requestData.UrlRequestType = UrlRequestType.Champion;

            result.AppendFreeData(WebRequestHelper.DoRequest<ChampionCollection>(requestData));

            return result;
        }
        
        public ItemCollection GetItemCollection()
        {
            //TODO: Optimize this class to default some of these as needed
            RequestData requestData = new RequestData();
            requestData.Region = "na";
            requestData.Version = "v1.2";
            requestData.UrlRequestType = UrlRequestType.Item;
            requestData.RequestType = RequestType.item;
            //TODO: Optimize this to do this by default
            if (ConfigurationManager.AppSettings.AllKeys.Contains<string>("APIKey"))
                requestData.APIKey = ConfigurationManager.AppSettings["APIKey"];

            return WebRequestHelper.DoRequest<ItemCollection>(requestData);
        }
    }
}
