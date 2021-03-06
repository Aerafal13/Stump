using System;
using Stump.ORM;
using Stump.ORM.SubSonic.SQLGeneration.Schema;
using Stump.Server.WorldServer.Game.Actors.Look;
using Stump.Server.WorldServer.Game.Maps;

namespace Stump.Server.WorldServer.Database.World
{
    public class WorldMapMerchantRelator
    {
        public static string FetchQuery = "SELECT * FROM world_maps_merchant";
    }

    [TableName("world_maps_merchant")]
    public sealed class WorldMapMerchantRecord : IAutoGeneratedRecord, ISaveIntercepter
    {
        private ActorLook m_entityLook;
        private string m_entityLookString;
        private Map m_map;

        [PrimaryKey("CharacterId", false)]
        public int CharacterId
        {
            get;
            set;
        }

        public int AccountId
        {
            get;
            set;
        }

        public int? MapId
        {
            get;
            set;
        }

        [Ignore]
        public Map Map
        {
            get
            {
                if (!MapId.HasValue)
                    return null;

                return m_map ?? (m_map = Game.World.Instance.GetMap(MapId.Value));
            }
            set
            {
                m_map = value;

                if (value == null)
                    MapId = null;
                else
                    MapId = value.Id;
            }
        }

        public int Cell
        {
            get;
            set;
        }

        public int Direction
        {
            get;
            set;
        }

        [Ignore]
        public ActorLook EntityLook
        {
            get { return m_entityLook; }
            set
            {
                m_entityLook = value;
                m_entityLookString = value.ToString();
            }
        }

        [NullString]
        public string EntityLookString
        {
            get { return m_entityLookString; }
            set
            {
                m_entityLookString = value;
                m_entityLook = !string.IsNullOrEmpty(EntityLookString) ? ActorLook.Parse(m_entityLookString) : null;
            }
        }

        public string Name
        {
            get;
            set;
        }

        public int SellType
        {
            get;
            set;
        }

        public bool IsActive
        {
            get;
            set;
        }

        public DateTime MerchantSince
        {
            get;
            set;
        }

        public void BeforeSave(bool insert)
        {
            m_entityLookString = m_entityLook.ToString();
        }
    }
}