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
    public class Image
    {
        [DataMember(Name = "full")]
        internal string mFull;
        [DataMember(Name = "group")]
        internal string mGroup;
        [DataMember(Name = "h")]
        internal int mH;
        [DataMember(Name = "sprit")]
        internal string mSprite;
        [DataMember(Name = "w")]
        internal int mW;
        [DataMember(Name = "x")]
        internal int mX;
        [DataMember(Name = "y")]
        internal int mY;
    }
}
