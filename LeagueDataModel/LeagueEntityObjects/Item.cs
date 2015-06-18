using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using LOLDotNet.LeagueDataModel.Utility;

namespace LOLDotNet.LeagueDataModel.LeagueEntityObjects
{
    [Serializable]
    [DataContract]
    public class Item
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
        [DataMember(Name = "effect")]
        public IDictionary<string, string> Effect { get; internal set; }
        [DataMember(Name = "from")]
        public IList<string> From { get; internal set; }
        [DataMember(Name = "gold")]
        public Gold Gold { get; internal set; }
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
        public IList<string> Into { get; internal set; }
        [DataMember(Name = "maps")]
        public IDictionary<string, bool> Maps { get; internal set; }
        [DataMember(Name = "name")]
        public string Name { get; internal set; }
        [DataMember(Name = "plaintext")]
        public string Plaintext { get; internal set;}
        [DataMember(Name = "requiredChampion")]
        public string RequiredChampion { get; internal set; }
        [DataMember(Name = "rune")]
        public MetaData Rune { get; internal set; }
        [DataMember(Name = "sanitizedDescription")]
        public string SanitizedDescription;
        [DataMember(Name = "specialRecipe")]
        public int SpecialRecipe {get; internal set;}
        [DataMember(Name = "stacks")]
        public int Stacks {get; internal set;}
        [DataMember(Name = "stats")]
        public BasicDataStats Stats { get; internal set; }
        [DataMember(Name = "tags")]
        public IList<string> Tags { get; internal set; }
    }

    [Serializable]
    [DataContract]
    public class ItemCollection
    {
        [DataMember(Name = "basic")]
        public BasicRuneData Basic { get; internal set; }
        [DataMember(Name = "data")]
        public IDictionary<string, Item> Data { get; internal set; }
        [DataMember(Name = "groups")]
        public List<Group> Groups { get; internal set; }
        [DataMember(Name = "tree")]
        public List<ItemTree> ItemTree { get; internal set; }
        [DataMember(Name = "type")]
        public string Type { get; internal set; }
        [DataMember(Name = "version")]
        public string Version { get; internal set; }
    }

    [Serializable]
    [DataContract]
    public class BasicRuneData
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
        [DataMember(Name = "gold")]
        public Gold Gold { get; internal set; }
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
        [DataMember(Name = "plaintext")]
        public string Plaintext { get; internal set; }
        [DataMember(Name = "requiredChampion")]
        public string RequiredChampion { get; internal set; }
        [DataMember(Name = "specialRecipe")]
        public int SpecialRecipe { get; internal set; }
        [DataMember(Name = "stacks")]
        public int Stacks { get; internal set; }
        [DataMember(Name = "stats")]
        public BasicDataStats Stats { get; internal set; }
        [DataMember(Name = "tags")]
        public List<string> Tags { get; internal set; }
    }

    [Serializable]
    [DataContract]
    public class Group
    {
        [DataMember(Name = "MaxGroupOwnable")]
        public string MaxGroupOwnable {get; internal set;}
        [DataMember(Name = "key")]
        public string Key { get; internal set; }
    }

    [Serializable]
    [DataContract]
    public class ItemTree
    {
        [DataMember(Name = "header")]
        public string Header { get; internal set; }
        [DataMember(Name = "tags")]
        public List<string> Tags { get; internal set; }
    }

    [Serializable]
    [DataContract]
    public class BasicDataStats
    {
        [DataMember(Name = "FlatArmorMod")]
        public double FlatArmorMod { get; internal set; }
        [DataMember(Name = "FlatAttackSpeedMod")]
        public double FlatAttackSpeedMod { get; internal set; }
        [DataMember(Name = "FlatCritChanceMod")]
        public double FlatCritChanceMod { get; internal set; }
        [DataMember(Name = "FlatCritModDamage")]
        public double FlatCritModDamage { get; internal set; }
        [DataMember(Name = "FlatEXPBonus")]
        public double FlatEXPBonus { get; internal set; }
        [DataMember(Name = "FlatEnergyPoolMod")]
        public double FlatEnergyPoolMod { get; internal set; }
        [DataMember(Name = "FlatEnergyRegenMod")]
        public double FlatEnergyRegenMod { get; internal set; }
        [DataMember(Name = "FlatHPPoolMod")]
        public double FlatHPPoolMod { get; internal set; }
        [DataMember(Name = "FlatHPRegenMod")]
        public double FlatHPRegenMod { get; internal set; }
        [DataMember(Name = "FlatMPPoolMod")]
        public double FlatMPPoolMod { get; internal set; }
        [DataMember(Name = "FlatMPRegenMod")]
        public double FlatMPRegenMod { get; internal set; }
        [DataMember(Name = "FlatMagicDamageMod")]
        public double FlatMagicDamageMod { get; internal set; }
        [DataMember(Name = "FlatMovementSpeedMod")]
        public double FlatMovementSpeedMod { get; internal set; }
        [DataMember(Name = "FlatPhysicalDamageMod")]
        public double FlatPhysicalDamageMod { get; internal set; }
        [DataMember(Name = "FlatSpellBlockMod")]
        public double FlatSpellBlockMod { get; internal set; }
        [DataMember(Name = "PercentArmorMod")]
        public double PercentArmorMod { get; internal set; }
        [DataMember(Name = "PercentAttackSpeedMod")]
        public double PercentAttackSpeedMod { get; internal set; }
        [DataMember(Name = "PercentBlockMod")]
        public double PercentBlockMod { get; internal set; }
        [DataMember(Name = "PercentCritChanceMod")]
        public double PercentCritChanceMod { get; internal set; }
        [DataMember(Name = "PercentCritDamageMod")]
        public double PercentCritDamageMod { get; internal set; }
        [DataMember(Name = "PercentDodgeMod")]
        public double PercentDodgeMod { get; internal set; }
        [DataMember(Name = "PercentEXPBonus")]
        public double PercentEXPBonus { get; internal set; }
        [DataMember(Name = "PercentHPPoolMod")]
        public double PercentHPPoolMod { get; internal set; }
        [DataMember(Name = "PercentHPRegenMod")]
        public double PercentHPRegenMod { get; internal set; }
        [DataMember(Name = "PercentLifeStealMod")]
        public double PercentLifeStealMod { get; internal set; }
        [DataMember(Name = "PercentMPPoolMod")]
        public double PercentMPPoolMod { get; internal set; }
        [DataMember(Name = "PercentMPRegenMod")]
        public double PercentMPRegenMod { get; internal set; }
        [DataMember(Name = "PercentMagicDamageMod")]
        public double PercentMagicDamageMod { get; internal set; }
        [DataMember(Name = "PercentMovementSpeedMod")]
        public double PercentMovementSpeedMod { get; internal set; }
        [DataMember(Name = "PercentPhysicalDamageMod")]
        public double PercentPhysicalDamageMod { get; internal set; }
        [DataMember(Name = "PercentSpellBlockMod")]
        public double PercentSpellBlockMod { get; internal set; }
        [DataMember(Name = "PercentSpellVampMod")]
        public double PercentSpellVampMod { get; internal set; }
        [DataMember(Name = "rFlatArmorModPerLevel")]
        public double rFlatArmorModPerLevel { get; internal set; }
        [DataMember(Name = "rFlatArmorPenetrationMod")]
        public double rFlatArmorPenetrationMod { get; internal set; }
        [DataMember(Name = "rFlatArmorPenetrationModPerLevel")]
        public double rFlatArmorPenetrationModPerLevel { get; internal set; }
        [DataMember(Name = "rFlatCritChanceModPerLevel")]
        public double rFlatCritChanceModPerLevel { get; internal set; }
        [DataMember(Name = "rFlatDodgeMod")]
        public double rFlatDodgeMod { get; internal set; }
        [DataMember(Name = "rFlatDodgeModPerLevel")]
        public double rFlatDodgeModPerLevel { get; internal set; }
        [DataMember(Name = "rFlatEnergyModPerLevel")]
        public double rFlatEnergyModPerLevel { get; internal set; }
        [DataMember(Name = "rFlatEnergyRegenModPerLevel")]
        public double rFlatEnergyRegenModPerLevel { get; internal set; }
    }

    [Serializable]
    [DataContract]
    public class MetaData
    {
        [DataMember(Name = "isRune")]
        public bool IsRune { get; internal set;}
        [DataMember(Name = "tier")]
        public string Tier { get; internal set;}
        [DataMember(Name = "type")]
        public string Type {get; internal set;}
    }

}
