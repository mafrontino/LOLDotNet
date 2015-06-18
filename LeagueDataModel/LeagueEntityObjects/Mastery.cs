using LOLDotNet.LeagueDataModel.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LOLDotNet.LeagueDataModel.LeagueEntityObjects
{
    public class Mastery
    {
        [DataMember(Name = "description")]
        public IList<string> Description { get; internal set; }
        [DataMember(Name = "id")]
        public int Id { get; internal set; }
        [DataMember(Name = "image")]
        public Image Image { get; internal set; }
        [DataMember(Name = "masteryTree")]
        public string MasteryTree { get; internal set; }
        [DataMember(Name = "name")]
        public string Name { get; internal set; }
        [DataMember(Name = "prereq")]
        public string Prereq { get; internal set; }
        [DataMember(Name = "ranks")]
        public int Ranks { get; internal set; }
        [DataMember(Name = "sanitizedDescription")]
        public IList<string> SanitizedDescription { get; internal set; }
    }

    public class MasteryCollection
    {
        [DataMember(Name = "data")]
        public IDictionary<string, Mastery> Data { get; internal set; }
        [DataMember(Name = "tree")]
        public MasteryTree Tree { get; internal set; }
        [DataMember(Name = "type")]
        public string Type { get; internal set;}
        [DataMember(Name = "version")]
        public string Version { get; internal set; }
    }

    public class MasteryTree
    {
        [DataMember(Name = "Defense")]
        public IList<MasteryTreeList> Defense { get; internal set; }
        [DataMember(Name = "Offense")]
        public IList<MasteryTreeList> Offense { get; internal set; } 
        [DataMember(Name = "Utility")]
        public IList<MasteryTreeList> Utility { get; internal set; }
    }

    public class MasteryTreeList
    {
        [DataMember(Name = "masteryTreeItems")]
        public List<MasteryTreeItem> MasteryTreeItems { get; internal set; }
    }

    public class MasteryTreeItem
    {
        [DataMember(Name = "masteryId")]
        public int MasteryId { get; internal set; }
        [DataMember(Name = "prereq")]
        public string Prereq { get; internal set; }
    }
}
