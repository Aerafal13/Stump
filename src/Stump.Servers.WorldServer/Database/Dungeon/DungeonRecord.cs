﻿//using Stump.Core.IO;
//using Stump.ORM;
//using Stump.ORM.SubSonic.SQLGeneration.Schema;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Stump.Server.WorldServer.Database.Dungeon
//{
//    public class DungeonRelator
//    {
//        public static string FetchQuery = "SELECT * FROM dungeons";
//    }

//    [TableName("dungeons")]
//    public class DungeonRecord : IAutoGeneratedRecord
//    {
//        private uint nameId;
//        private int optimalPlayerLevel;
//        private int[] m_mapIds;
//        private string m_mapIdsCSV;

//        private int firstRoom;
//        private int entranceMapId;
//        private int exitMapId;

//        [PrimaryKey("Id")]
//        public int Id
//        {
//            get;
//            set;
//        }
//        public uint NameId { get => nameId; set => nameId = value; }
//        public int OptimalPlayerLevel { get => optimalPlayerLevel; set => optimalPlayerLevel = value; }
//        public string MapIdsCSV
//        {
//            get { return m_mapIdsCSV; }
//            set
//            {
//                m_mapIdsCSV = value;
//                m_mapIds = value.FromCSV<int>(",");
//            }
//        }

//        [Ignore]
//        public int[] MapIds
//        {
//            get { return m_mapIds; }
//            set
//            {
//                m_mapIds = value;
//                m_mapIdsCSV = value.ToCSV(",");
//            }
//        }
//        public int FirstRoom { get => firstRoom; set => firstRoom = value; }
//        public int EntranceMapId { get => entranceMapId; set => entranceMapId = value; }
//        public int ExitMapId { get => exitMapId; set => exitMapId = value; }

//        #region IAssignedByD2O Members

//        public void AssignFields(object d2oObject)
//        {
//            var map = (Stump.DofusProtocol.D2oClasses.Dungeon)d2oObject;
//            MapIds = map.mapIds.ToArray();
//        }

//        #endregion

//        #region ISaveIntercepter Members

//        public void BeforeSave(bool insert)
//        {
//            m_mapIdsCSV = MapIds.ToCSV(",");
//        }

//        #endregion
//    }
//}
