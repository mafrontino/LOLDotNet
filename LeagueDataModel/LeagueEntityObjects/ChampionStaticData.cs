using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using LOLDotNet.LeagueDataModel.Utility;
using LOLDotNet.LeagueDataModel.LeagueEntityObjects;

namespace LOLDotNet.LeagueDataModel.LeagueEntityObjects
{
    [Serializable]
    [DataContract]
    public class ChampionSpell
    {
        [DataMember(Name = "altimages")]
        internal List<Image> mAltImages;
        [DataMember(Name = "cooldown")]
        internal double[] mCooldown;
        [DataMember(Name = "cooldownBurn")]
        internal string mCooldownBurn;
        [DataMember(Name = "cost")]
        internal int[] mCost;
        [DataMember(Name = "costBurn")]
        internal string mCostBurn;
        [DataMember(Name = "costType")]
        internal string mCostType;
        [DataMember(Name = "description")]
        internal string mDescription;
        [DataMember(Name = "image")]
        internal Image mImage;
        [DataMember(Name = "key")]
        internal string mKey;
        [DataMember(Name = "leveltip")]
        internal LevelTip mLevelTip;
        [DataMember(Name = "maxrank")]
        internal int mMaxrank;
        [DataMember(Name = "name")]
        internal string mName;
        [DataMember(Name = "range")]
        internal dynamic mRange;//Can either be list of ints or the string self
        [DataMember(Name = "rangeBurn")]
        internal string mRangeBurn;
        [DataMember(Name = "resource")]
        internal string mResource;
        [DataMember(Name = "sanitizedDescription")]
        internal string mSanitizedDescription;
        [DataMember(Name = "sanitizedTooltip")]
        internal string mSanitizedTooltip;
        [DataMember(Name = "tooltip")]
        internal string mTooltip;
        [DataMember(Name = "vars")]
        internal List<SpellVars> mVars;

        public List<Image> AltImages { get { return mAltImages; } }
        public double[] Cooldown { get { return mCooldown; } }
        public string CooldownBurn { get { return mCooldownBurn; } }
        public int[] Cost { get { return mCost; } }
        public string CostBurn { get { return mCostBurn; } }
        public string CostType { get { return mCostType; } }
        public string Description { get { return mDescription; } }
        public Image Image { get { return mImage; } }
        public string Key { get { return mKey; } }
        public LevelTip LevelTip { get { return mLevelTip; } }
        public int MaxRank { get { return mMaxrank; } }
        /// <summary>
        /// Can either be a list of ints or the string "self"
        /// </summary>
        public dynamic Range { get { return mRange; } }
        public string RangeBurn { get { return mRangeBurn; } }
        public string Resource { get { return mResource; } }
        public string SanitizedDescription { get { return mSanitizedDescription; } }
        public string SanitizedTooltip { get { return mSanitizedTooltip; } }
        public string Tooltip { get { return mTooltip; } }
        public List<SpellVars> Vars { get { return mVars; } }
    }

    [Serializable]
    [DataContract]
    public class Info
    {
        [DataMember(Name = "attack")]
        internal int mAttack;
        [DataMember(Name = "defense")]
        internal int mDefense;
        [DataMember(Name = "difficulty")]
        internal int mDifficulty;
        [DataMember(Name = "magic")]
        internal int mMagic;

        public int Attack { get { return mAttack; } }
        public int Defense { get { return mDefense; } }
        public int Difficulty { get { return mDifficulty; } }
        public int Magic { get {return mMagic;}}
    }

    [Serializable]
    [DataContract]
    public class Passive
    {
        [DataMember(Name = "description")]
        internal string mDescription;
        [DataMember(Name = "image")]
        internal Image mImage;
        [DataMember(Name = "name")]
        internal string mName;
        [DataMember(Name = "sanitizedDescription")]
        internal string mSanitizedDescription;

        public string Description { get { return mDescription;}}
        public Image Image { get { return mImage;}}
        public string Name { get { return mName;}}
        public string SanitizedDescription { get { return mSanitizedDescription;} }
    }

    [Serializable]
    [DataContract]
    public class Stats
    {
        [DataMember(Name = "armor")]
        internal double mArmor;
        [DataMember(Name = "armorperlevel")]
        internal double mArmorPerLevel;
        [DataMember(Name = "attackdamage")]
        internal double mAttackDamage;
        [DataMember(Name = "attackdamageperlevel")]
        internal double mAttackDamagePerLevel;
        [DataMember(Name = "crit")]
        internal double mCrit;
        [DataMember(Name = "critperlevel")]
        internal double mCritPerLevel;
        [DataMember(Name = "hp")]
        internal double mHp;
        [DataMember(Name = "hpperlevel")]
        internal double mHpPerLevel;
        [DataMember(Name = "hpregen")]
        internal double mHpRegen;
        [DataMember(Name = "hpregenperlevel")]
        internal double mHpRegenPerLevel;
        [DataMember(Name = "movespeed")]
        internal double mMoveSpeed;
        [DataMember(Name = "mp")]
        internal double mMp;
        [DataMember(Name = "mpperlevel")]
        internal double mMpPerLevel;
        [DataMember(Name = "spellblock")]
        internal double mSpellBlock;
        [DataMember(Name = "spellblockperlevel")]
        internal double mSpellBlockPerLevel;

        public double Armor { get { return mArmor; } }
        public double ArmorPerLevel { get { return mArmorPerLevel; } }
        public double AttackDamage { get { return mAttackDamage; } }
        public double AttackDamagePerLevel { get { return mAttackDamagePerLevel; } }
        public double Crit { get { return mCrit; } }
        public double CritPerLevel { get { return mCritPerLevel; } }
        public double Hp { get { return mHp; } }
        public double HpPerLevel { get { return mHpPerLevel; } }
        public double HpRegen { get { return mHpRegen; } }
        public double HpRegenPerLevel { get { return mHpRegenPerLevel; } }
        public double MoveSpeed { get { return mMoveSpeed; } }
        public double Mp { get { return mMp; } }
        public double MpPerLevel { get { return mMpPerLevel; } }
        public double SpellBlock { get { return mSpellBlock; } }
        public double SpellBlockPerLevel { get { return mSpellBlockPerLevel; } }

    }

    [Serializable]
    [DataContract]
    public class Skin
    {
        [DataMember(Name = "id")]
        internal int mId;
        public int Id 
        {
            get { return mId; }
        }

        [DataMember(Name = "name")]
        internal string mName;
        public string Name 
        {
            get { return mName; }
        }

        [DataMember(Name = "num")]
        internal int mNum;
        public int Num 
        {
            get { return mNum; }
        }
    }

    [Serializable]
    [DataContract]
    public class Recommended
    {

        [DataMember(Name = "champion")]
        public string Champion { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "map")]
        public string Map { get; set; }

        [DataMember(Name = "mode")]
        public string Mode { get; set; }

        [DataMember(Name = "priority")]
        public bool Priority { get; set; }

        [DataMember(Name = "blocks")]
        public List<Block> Blocks { get; set; }
    }

    [Serializable]
    [DataContract]
    public class Block
    {
        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "items")]
        public Item[] Items { get; set; }

        [DataMember(Name = "recMath")]
        public bool? RecMath { get; set; }
    }

    [Serializable]
    [DataContract]
    public class SpellVars
    {
        [DataMember(Name = "coeff")]
        public List<double> Coeff { get; internal set; }
        [DataMember(Name = "dyn")]
        public string Dyn { get; internal set; }
        [DataMember(Name = "key")]
        public string Key { get; internal set; }
        [DataMember(Name = "link")]
        public string Link { get; internal set; }
        [DataMember(Name = "ranksWith")]
        public string RanksWith { get; internal set; }


    }

    [Serializable]
    [DataContract]
    public class BlockItem
    {
        [DataMember(Name = "count")]
        public int Count { get; internal set; }
        [DataMember(Name = "id")]
        public int Id { get; internal set; }
    }

    [Serializable]
    [DataContract]
    public class LevelTip
    {
        [DataMember(Name = "effect")]
        public List<string> Effect { get; internal set; }
        [DataMember(Name = "label")]
        public List<string> Label { get; internal set; }
    }

}
