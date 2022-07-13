﻿using Stump.Core.IO;
using Stump.DofusProtocol.D2oClasses.Tools.D2o;
using Stump.ORM;
using Stump.ORM.SubSonic.SQLGeneration.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stump.Server.WorldServer.Database.HavenBags
{
    public class HavenBagThemesRelator
    {
        public static string FetchQuery = "SELECT * FROM havenbags_themes";
    }
    [TableName("havenbags_themes")]
    [D2OClass("HavenbagTheme", "com.ankamagames.dofus.datacenter.houses")]
    public class HavenBagThemes : IAssignedByD2O, IAutoGeneratedRecord
    {
        [PrimaryKey("Id", false)]
        public int Id
        {
            get;
            set;
        }

        public int MapId
        {
            get;
            set;
        }

        public int CellId
        {
            get;
            set;
        }

        public int NameId
        {
            get;
            set;
        }

        public void AssignFields(object d2oObject)
        {
            var havenbagtheme = (Stump.DofusProtocol.D2oClasses.HavenbagTheme)d2oObject;
            Id = havenbagtheme.Id;
            MapId = (int)havenbagtheme.MapId;
            NameId = havenbagtheme.NameId;
        }
    }
}
