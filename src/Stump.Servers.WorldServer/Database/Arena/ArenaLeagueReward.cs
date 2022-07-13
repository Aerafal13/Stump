﻿using Stump.Core.IO;
using Stump.DofusProtocol.D2oClasses;
using Stump.ORM;
using Stump.ORM.SubSonic.SQLGeneration.Schema;
using System.Collections.Generic;
using System.Linq;

namespace Stump.Server.WorldServer.Database.Arena
{
    public class ArenaLeagueRewardRelator
    {
        public static string FetchQuery = "SELECT * FROM arena_leagues_rewards";
    }

    [TableName("arena_leagues_rewards")]
    public class ArenaLeagueReward : IAutoGeneratedRecord
    {
        [PrimaryKey("Id")]
        public int Id
        {
            get;
            set;
        }

        public int RewardId
        {
            get;
            set;
        }

        public uint SeasonId
        {
            get;
            set;
        }

        public uint LeagueId
        {
            get;
            set;
        }

        [Ignore]
        public List<uint> TitlesRewards
        {
            get
            {
                return TitlesRewardsCSV.FromCSV<uint>(",").ToList();
            }
            set { TitlesRewardsCSV = value.ToCSV(","); }
        }

        public string TitlesRewardsCSV
        {
            get;
            set;
        }

        public bool EndSeasonRewards
        {
            get;
            set;
        }

        public void AssignFields(object obj)
        {
            var reward = (DofusProtocol.D2oClasses.ArenaLeagueReward)obj;
            RewardId = reward.Id;
            LeagueId = reward.LeagueId;
            TitlesRewards = reward.TitlesRewards;
            EndSeasonRewards = reward.EndSeasonRewards;

        }
    }
}
