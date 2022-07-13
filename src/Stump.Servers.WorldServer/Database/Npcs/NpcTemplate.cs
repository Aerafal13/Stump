using System.Collections.Generic;
using System.Linq;
using Stump.Core.IO;
using Stump.DofusProtocol.D2oClasses.Tools.D2o;
using Stump.ORM;
using Stump.ORM.SubSonic.SQLGeneration.Schema;
using Stump.Server.WorldServer.Database.I18n;
using Stump.Server.WorldServer.Database.Npcs.Actions;
using Stump.Server.WorldServer.Game.Actors.Look;
using Stump.Server.WorldServer.Game.Actors.RolePlay.Npcs;
using Npc = Stump.Server.WorldServer.Game.Actors.RolePlay.Npcs.Npc;

namespace Stump.Server.WorldServer.Database.Npcs
{
    public class NpcTemplateRelator
    {
        public static string FetchQuery = "SELECT * FROM npcs_templates";
    }

    [TableName("npcs_templates")]
    [D2OClass("Npc", "com.ankamagames.dofus.datacenter.npcs")]
    public class NpcTemplate : IAssignedByD2O, ISaveIntercepter, IAutoGeneratedRecord
    {
        #region Delegates

        public delegate void NpcSpawnedEventHandler(NpcTemplate template, Npc npc);

        #endregion

        private List<NpcActionDatabase> m_actions;
        private string m_actionsIdsCSV;
        private string m_dialogMessagesIdCSV;
        private string m_dialogRepliesIdCSV;
        private ActorLook m_entityLook;
        private string m_lookAsString;
        private string m_name;

        [PrimaryKey("Id", false)]
        public int Id
        {
            get;
            set;
        }

        public uint NameId
        {
            get;
            set;
        }

        public string Name
        {
            get { return m_name ?? (m_name = TextManager.Instance.GetText(NameId)); }
        }

        public string DialogMessagesIdCSV
        {
            get { return m_dialogMessagesIdCSV; }
            set
            {
                m_dialogMessagesIdCSV = value;
                DialogMessagesId = m_dialogMessagesIdCSV.FromCSV(";", x => x.FromCSV<int>(","));
            }
        }

        [Ignore]
        public int[][] DialogMessagesId
        {
            get;
            set;
        }

        public string DialogRepliesIdCSV
        {
            get { return m_dialogRepliesIdCSV; }
            set
            {
                m_dialogRepliesIdCSV = value;
                DialogRepliesId = m_dialogRepliesIdCSV.FromCSV(";", x => x.FromCSV<int>(","));
            }
        }

        [Ignore]
        public int[][] DialogRepliesId
        {
            get;
            set;
        }

        public string ActionsIdsCSV
        {
            get { return m_actionsIdsCSV; }
            set
            {
                m_actionsIdsCSV = value;
                ActionsIds = m_actionsIdsCSV.FromCSV<uint>(",");
            }
        }

        [Ignore]
        public uint[] ActionsIds
        {
            get;
            set;
        }

        public List<NpcActionDatabase> Actions
        {
            get { return m_actions ?? (m_actions = NpcManager.Instance.GetNpcActions(Id)); }
        }

        public uint Gender
        {
            get;
            set;
        }

        public string LookAsString
        {
            get
            {
                if (m_entityLook == null)
                    return string.Empty;

                if (string.IsNullOrEmpty(m_lookAsString))
                    m_lookAsString = Look.ToString();

                return m_lookAsString;
            }
            set
            {
                m_lookAsString = value;

                if (value != null)
                    m_entityLook = ActorLook.Parse(m_lookAsString);
            }
        }

        [Ignore]
        public ActorLook Look
        {
            get { return m_entityLook; }
            set
            {
                m_entityLook = value;

                if (value != null)
                    m_lookAsString = value.ToString();
            }
        }

        public short SpecialArtworkId
        {
            get;
            set;
        }

        public int TokenShop
        {
            get;
            set;
        }

        #region IAssignedByD2O Members

        public void AssignFields(object d2oObject)
        {
            var npc = (DofusProtocol.D2oClasses.Npc) d2oObject;
            Id = npc.id;
            NameId = npc.nameId;
            DialogMessagesId = npc.dialogMessages.Select(x => x.ToArray()).ToArray();
            DialogRepliesId = npc.dialogReplies.Select(x => x.ToArray()).ToArray();
            ActionsIds = npc.actions.ToArray();
            ;
            Gender = npc.gender;
            LookAsString = npc.look;
            TokenShop = npc.tokenShop;
        }

        #endregion

        #region ISaveIntercepter Members

        public void BeforeSave(bool insert)
        {
            m_dialogMessagesIdCSV = DialogMessagesId.ToCSV(";", x => x.ToCSV(","));
            m_dialogRepliesIdCSV = DialogRepliesId.ToCSV(";", x => x.ToCSV(","));
            m_actionsIdsCSV = ActionsIds.ToCSV(",");
        }

        #endregion

        public event NpcSpawnedEventHandler NpcSpawned;

        public void OnNpcSpawned(Npc npc)
        {
            NpcSpawnedEventHandler handler = NpcSpawned;
            if (handler != null) handler(this, npc);
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Name, Id);
        }
    }
}