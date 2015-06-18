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
    public class Rune
    {
        [DataMember(Name = "colloq")]
        public string Colloq { get; internal set; }
        [DataMember(Name = "consumeOnFull")]
        public bool ConsumeOnFull { get; internal set; }
        [DataMember(Name = "consumed")]
        public bool Consumed { get; internal set; }
        [DataMember(Name = "depth")]
        public int Depth { get; internal set; }
        [DataMember(Name = "description")]
        public string Description { get; internal set; }
        [DataMember(Name = "from")]
        public List<string> From { get; internal set; }
        [DataMember(Name = "group")]
        public string Group { get; internal set; }
        [DataMember(Name = "hideFromAll")]
        public bool HideFromAll { get; internal set; }
        [DataMember(Name = "id")]
        public int Id { get; internal set; }
        [DataMember(Name = "image")]
        public Image Image { get; internal set; }
        [DataMember(Name = "inStore")]
        public bool InStore { get; internal set; }
        [DataMember(Name = "into")]
        public List<string> Into { get; internal set; }
        [DataMember(Name = "maps")]
        public Dictionary<string, bool> Maps { get; internal set; }
        [DataMember(Name = "name")]
        public string Name { get; internal set; }
        [DataMember(Name = "plaintext")]
        public string Plaintext { get; internal set; }
        [DataMember(Name = "requiredChampion")]
        public string RequiredChampion { get; internal set; }
        [DataMember(Name = "rune")]
        public MetaData Rune { get; internal set; }
        [DataMember(Name = "sanitizedDescription")]
        public string SanitizedDescription { get; internal set; }
        [DataMember(Name = "specialRecipe")]
        public int SpecialRecipe { get; internal set; }
        [DataMember(Name = "stacks")]
        public int Stacks { get; internal set; }
        [DataMember(Name = "stats")]
        public BasicDataStats Stats { get; internal set; }
        [DataMember(Name = "tags")]
        public List<string> Tags { get; internal set; }
    }

    [DataContract]
    [Serializable]
    public class RuneCollection
    {
        [DataMember(Name = "basic")]
        public BasicRuneData Basic { get; internal set; }
        [DataMember(Name = "data")]
        public Dictionary<string, Rune> Data { get; internal set; }
        [DataMember(Name = "type")]
        public string Type { get; internal set; }
        [DataMember(Name = "version")]
        public string Version { get; internal set; }
    }

    [DataContract]
    [Serializable]
    public class BasicRuneData
    {
        [DataMember(Name = "colloq")]
        public string Colloq { get; internal set; }
        [DataMember(Name = "consumeOnFull")]
        public bool ConsumeOnFull { get; internal set; }
        [DataMember(Name = "consume")]
        public bool Consumed { get; internal set; }
        [DataMember(Name = "depth")]
        public int Depth { get; internal set; }
        [DataMember(Name = "description")]
        public string Description { get; internal set; }
        [DataMember(Name = "from")]
        public List<string> From { get; internal set; }
        [DataMember(Name = "gold")]
        public Gold Gold { get; internal set; }
        [DataMember(Name = "group")]
        public List<string> Group { get; internal set; }
        [DataMember(Name = "hideFromAll")]
        public bool HideFromAll { get; internal set; }
        [DataMember(Name = "id")]
        public int Id { get; internal set; }
        [DataMember(Name = "image")]
        public Image Image { get; internal set; }
        [DataMember(Name = "inStore")]
        public bool InStore { get; internal set; }
        [DataMember(Name = "into")]
        public List<string> Into { get; internal set; }
        [DataMember(Name = "maps")]
        public Dictionary<string, bool> Maps { get; internal set; }
        [DataMember(Name = "name")]
        public string Name { get; internal set; }
        [DataMember(Name = "plaintext")]
        public string Plaintext { get; internal set; }
        [DataMember(Name = "requiredChampion")]
        public string RequiredChampion { get; internal set; }
        [DataMember(Name = "rune")]
        public MetaData Rune { get; internal set; }
        [DataMember(Name = "sanitizedDescription")]
        public string SanitizedDescription { get; internal set; }
        [DataMember(Name = "specialRecipe")]
        public int SpecialRecipe { get; internal set; }
        [DataMember(Name = "stacks")]
        public int Stacks { get; internal set; }
        [DataMember(Name = "stats")]
        public BasicDataStats Stats { get; internal set; }
        [DataMember(Name = "tags")]
        public List<string> Tags { get; internal set; }
    }

}
