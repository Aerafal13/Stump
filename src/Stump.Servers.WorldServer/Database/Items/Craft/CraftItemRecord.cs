﻿using Stump.ORM;
using Stump.ORM.SubSonic.SQLGeneration.Schema;

namespace Stump.Server.WorldServer.Database.Items.Craft
{
    public class CraftItemRelator
    {
        public static string FetchQuery = "SELECT * FROM items_craft_history";
        public static string FetchById =
            "SELECT * FROM items_craft_history WHERE ItemId = {0} AND OwnerId = {1}";
    }

    [TableName("items_craft_history")]
    public class CraftItemRecord : IAutoGeneratedRecord
    {
        public CraftItemRecord()
        {

        }

        [PrimaryKey("Id")]
        public int Id
        {
            get;
            set;
        }

        public int ItemId
        {
            get;
            set;
        }

        public int Amount
        {
            get;
            set;
        }

        public int OwnerId
        {
            get;
            set;
        }
    }
}