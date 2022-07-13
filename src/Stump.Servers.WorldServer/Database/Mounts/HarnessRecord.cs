﻿using System.Drawing;
using System.Linq;
using Stump.ORM;
using Stump.ORM.SubSonic.SQLGeneration.Schema;
using Stump.Server.WorldServer.Database.Items.Templates;
using Stump.Server.WorldServer.Game.Items;

namespace Stump.Server.WorldServer.Database.Mounts
{
    public class HarnessRelator
    {
        public static string FetchQuery = "SELECT * FROM mounts_harness";
    }


    [TableName("mounts_harness")]
    public class HarnessRecord : IAutoGeneratedRecord
    {
        private ItemTemplate m_template;

        [PrimaryKey("ItemId")]
        public int ItemId
        {
            get;
            set;
        }

        public ItemTemplate ItemTemplate => m_template ?? (m_template = ItemManager.Instance.TryGetTemplate(ItemId));

        public int SkinId
        {
            get;
            set;
        }

        public int? Color1
        {
            get;
            set;
        }
        
        public int? Color2
        {
            get;
            set;
        }

        public int? Color3
        {
            get;
            set;
        }
        
        public int? Color4
        {
            get;
            set;
        }
        
        public int? Color5
        {
            get;
            set;
        }

        public Color[] Colors => new[] {Color1, Color2, Color3, Color4, Color5}.Where(x => x != null).Select(x => Color.FromArgb(x.Value)).ToArray();
    }
}