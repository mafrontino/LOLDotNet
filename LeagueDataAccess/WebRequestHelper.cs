using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using LOLDotNet.LeagueDataModel.DataAccessObjects;

namespace LOLDotNet.LeagueDataAccess.DataAccess
{
    public class WebRequestHelper
    {
        public const string DEFAULT_PROTOCOL = "https://";

        public static string GetUrl(RequestData requestData)
        {
            StringBuilder result = new StringBuilder(DEFAULT_PROTOCOL);
            switch(requestData.UrlRequestType)
            {
                case UrlRequestType.Champion:
                    result.Append(requestData.Region);
                    result.Append(".api.pvp.net/api/lol/");
                    result.Append(requestData.Region);
                    result.Append("/");
                    result.Append(requestData.Version);
                    result.Append("/");
                    result.Append(requestData.RequestType.ToString());
                    result.Append("?");
                    AddKeyData(result, requestData);
                    break;
                case UrlRequestType.ChampionStaticData:
                    result.Append(requestData.Region);
                    result.Append(".api.pvp.net/api/lol/static-data/");
                    result.Append(requestData.Region);
                    result.Append("/");
                    result.Append(requestData.Version);
                    result.Append("/");
                    result.Append(requestData.RequestType.ToString());
                    //result.Append("/");
                    //result.Append(requestData.Id);
                    result.Append("?");
                    if(requestData.ChampDataType != ChampDataType.None)
                    {
                        result.Append("champData=");
                        result.Append(requestData.ChampDataType.ToString());
                        result.Append("&");
                    }
                    AddKeyData(result, requestData);
                    break;
                case UrlRequestType.Item:
                    result.Append(requestData.Region);
                    result.Append(".api.pvp.net/api/lol/static-data/");
                    result.Append(requestData.Region);
                    result.Append("/");
                    result.Append(requestData.Version);
                    result.Append("/");
                    result.Append(requestData.RequestType.ToString());
                    result.Append("?");
                    AddKeyData(result, requestData);
                    break;

            }
            return result.ToString();
        }

        public static T DoRequest<T>(RequestData rd)
        {
            string url = GetUrl(rd);
            WebRequest request = WebRequest.Create(url);
            Stream JsonStream = request.GetResponse().GetResponseStream();
            DataContractJsonSerializerSettings settings = new DataContractJsonSerializerSettings();
            settings.UseSimpleDictionaryFormat = true;
            DataContractJsonSerializer converter = new DataContractJsonSerializer(typeof(T), settings);
            return (T)converter.ReadObject(JsonStream);
        }

        private static void AddKeyData(StringBuilder sb, RequestData rd)
        {
            sb.Append("api_key=");
            if(!string.IsNullOrEmpty(rd.APIKey))
            {
                sb.Append(rd.APIKey);
            }
            else
            {
                sb.Append(Properties.Resources.Key);
            }
        }
    }

}
