using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LOLDotNet.LeagueDataModel.Utility
{
    [Serializable]
    [DataContract]
    public class Gold
    {
        [DataMember(Name = "base")]
        public int Base { get; internal set; }
        [DataMember(Name = "purchasable")]
        public bool Purchasable { get; internal set; }
        [DataMember(Name = "sell")]
        public int Sell { get; internal set; }
        [DataMember(Name = "total")]
        public int Total { get; internal set; }
    }
}
