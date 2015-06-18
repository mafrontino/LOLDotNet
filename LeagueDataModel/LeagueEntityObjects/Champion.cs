using LOLDotNet.LeagueDataModel.DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using LOLDotNet.LeagueDataModel.Utility;

namespace LOLDotNet.LeagueDataModel.LeagueEntityObjects
{
    [Serializable]
    [DataContract]
    public class Champion
    {
        #region ChampionLiveData
        [DataMember(Name = "botMmEnabled")]
        internal bool mBotMmEnabled;
        //[DataMember(Name = "id")]
        //internal int mId;
        [DataMember(Name = "rankedPlayEnabled")]
        internal bool mRankedPlayEnabled;
        [DataMember(Name = "botEnabled")]
        internal bool mBotEnabled;
        [DataMember(Name = "active")]
        internal bool mActive;
        [DataMember(Name = "freeToPlay")]
        internal bool mFreeToPlay;

        public bool BotMmEnabled
        {
            get { return mBotEnabled; }
        }

        //Duplicate Member in static data
        //public int Id
        //{
        //    get { return mId; }
        //}

        public bool RankedPlayEnabled
        {
            get { return mRankedPlayEnabled; }
        }

        public bool Active
        {
            get { return mActive; }
        }

        public bool FreeToPlay
        {
            get { return mFreeToPlay; }
        }

        #endregion

        #region ChampionStaticData
        [DataMember(Name = "allytips")]
        internal List<string> mAllyTips;
        [DataMember(Name = "blurb")]
        internal string mBlurb;
        [DataMember(Name = "enemytips")]
        internal List<string> mEnemyTips;
        [DataMember(Name = "id")]
        internal int mId;
        [DataMember(Name = "image")]
        internal Image mImage;
        [DataMember(Name = "info")]
        internal Info mInfo;
        [DataMember(Name = "key")]
        internal string mKey;
        [DataMember(Name = "lore")]
        internal string mLore;
        [DataMember(Name = "name")]
        internal string mName;
        [DataMember(Name = "partype")]
        internal string mPartype;
        [DataMember(Name = "passive")]
        internal Passive passive;
        [DataMember(Name = "recommended")]
        internal List<Recommended> mRecommended;
        [DataMember(Name = "skins")]
        internal List<Skin> mSkins;
        [DataMember(Name = "spells")]
        internal List<ChampionSpell> mSpells;
        [DataMember(Name = "stats")]
        internal Stats mStats;
        [DataMember(Name = "tags")]
        internal List<string> mTags;
        [DataMember(Name = "title")]
        internal string mTitle;

        public List<string> AllyTips { get { return mAllyTips; } }
        public string Blurb { get { return mBlurb; } }
        public List<string> EnemyTips { get { return mEnemyTips; } }
        public int Id { get { return mId; } }
        public string Key { get { return mKey; } }
        public string Lore { get { return mLore; } }
        public string Name { get { return mName; } }
        public string Partype { get { return mPartype; } }
        public List<Skin> Skins { get { return mSkins; } }
        public List<ChampionSpell> Spells { get { return mSpells; } }
        public Stats Stats { get { return mStats; } }
        public List<string> Tags { get { return mTags; } }
        public string Title { get { return mTitle; } }
        public List<Recommended> Recommended { get { return mRecommended; } }
        #endregion
    }

    [Serializable]
    [DataContract]
    public class ChampionCollection
    {
        [DataMember(Name = "champions")]
        private List<Champion> mFreeChampionData; //Temp storage for FreeChampLiveData

        [DataMember(Name = "data")]
        public IDictionary<string, Champion> mData;
        [DataMember(Name = "format")]
        internal string mFormat;
        [DataMember(Name = "keys")]
        internal Dictionary<string, string> mKeys;
        [DataMember(Name = "type")]
        internal string mType;
        [DataMember(Name = "version")]
        internal string mVersion;

        public string Format { get { return mFormat; } }
        public Dictionary<string,string> Keys { get { return mKeys; } }
        public string Type { get { return mType; } }
        public string Version { get { return mVersion; } }
        public IDictionary<string, Champion> Champions { get { return mData; } }

        public Champion this[int i]
        {
            get 
            {
                return GetChampion(i);
            }
        }
        public Champion this[string name]
        {
            get
            {
                return GetChampion(name);
            }
        }

        private Champion GetChampion(int id)
        {
            Champion result = null;
            if(mKeys != null && mData != null)
            {
                string keyValue;
                if(mKeys.TryGetValue(id.ToString(), out keyValue))
                {
                    mData.TryGetValue(keyValue, out result);
                }
            }
            return result;
        }
        private Champion GetChampion(string name)
        {
            Champion result = null;
            if (mData != null)
            {
                mData.TryGetValue(name, out result);
            }
            return result;
        }

        public void AppendFreeData(ChampionCollection championFreeData)
        {
            foreach(var champion in championFreeData.mFreeChampionData)
            {
                Champion targetChamp = this[champion.Id];
                targetChamp.mBotMmEnabled = champion.mBotMmEnabled;
                targetChamp.mId = champion.mId;
                targetChamp.mRankedPlayEnabled = champion.mRankedPlayEnabled;
                targetChamp.mBotEnabled = champion.mBotEnabled;
                targetChamp.mFreeToPlay = champion.mFreeToPlay;
                targetChamp.mActive = champion.mActive;
            }
        }
    }

}
