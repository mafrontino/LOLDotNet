using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLDotNet.LeagueDataModel.DataAccessObjects
{

    public class RequestData
    {
        private string mRegion = "na";
        public string Region
        {
            get { return mRegion; }
            set { mRegion = value; }
        }

        public string Version;
        public RequestType RequestType;
        public UrlRequestType UrlRequestType;
        public int Id;
        public ChampDataType ChampDataType;

        public string APIKey;
    }

    public enum RequestType
    {
        champion,
        item
    }

    public enum UrlRequestType
    {
        Champion,
        ChampionStaticData,
        Item
    }

    public enum ChampDataType
    {
        None,
        all
    }

}
