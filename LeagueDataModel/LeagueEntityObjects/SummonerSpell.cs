using LOLDotNet.LeagueDataModel.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LOLDotNet.LeagueDataModel.LeagueEntityObjects
{
    [DataContract]
    [Serializable]
    public class SummonerSpell
    {
        [DataMember(Name = "cooldown")]
        public Dictionary<string, SummonerSpell> Cooldown { get; internal set; }
        [DataMember(Name = "cooldownBurn")]
        public string CooldownBurn { get; internal set; }
        [DataMember(Name = "cost")]
        public List<int> Cost { get; internal set; }
        [DataMember(Name = "costBurn")]
        public string CostBurn { get; internal set; }
        [DataMember(Name = "costType")]
        public string CostType { get; internal set; }
        [DataMember(Name = "description")]
        public string Description { get; internal set; }
        [DataMember(Name = "effect")]
        public List<List<double>> Effect { get; internal set; } //List of list of double
        [DataMember(Name = "effectBurn")]
        public List<string> EffectBurn { get; internal set; }
        [DataMember(Name = "id")]
        public int Id { get; internal set; }
        [DataMember(Name = "image")]
        public Image Image { get; internal set; } 

    }

    [DataContract]
    [Serializable]
    public class SummonerSpellCollection
    {
        [DataMember(Name = "data")]
        public Dictionary<string, SummonerSpell> Data { get; internal set;}
        [DataMember(Name = "type")]
        public string Type { get; internal set; }
        [DataMember(Name = "version")]
        public string Version { get; internal set; }


    }

    [DataContract]
    [Serializable]
    public class LevelTip
    {


    }

    [DataContract]
    [Serializable]
    public class SpellVars
    {


    }
}
