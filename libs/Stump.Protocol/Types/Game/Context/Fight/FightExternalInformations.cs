namespace Stump.DofusProtocol.Types
{
    using System;
    using System.Linq;
    using System.Text;
    using Stump.DofusProtocol.Types;
    using System.Collections.Generic;
    using Stump.Core.IO;

    [Serializable]
    public class FightExternalInformations
    {
        public const short Id  = 117;
        public virtual short TypeId
        {
            get { return Id; }
        }
        public ushort FightId { get; set; }
        public sbyte FightType { get; set; }
        public int FightStart { get; set; }
        public bool FightSpectatorLocked { get; set; }

        public FightExternalInformations(ushort fightId, sbyte fightType, int fightStart, bool fightSpectatorLocked)
        {
            this.FightId = fightId;
            this.FightType = fightType;
            this.FightStart = fightStart;
            this.FightSpectatorLocked = fightSpectatorLocked;
        }

        public FightExternalInformations() { }

        public virtual void Serialize(IDataWriter writer)
        {
            writer.WriteVarUShort(FightId);
            writer.WriteSByte(FightType);
            writer.WriteInt(FightStart);
            writer.WriteBoolean(FightSpectatorLocked);
        }

        public virtual void Deserialize(IDataReader reader)
        {
            FightId = reader.ReadVarUShort();
            FightType = reader.ReadSByte();
            FightStart = reader.ReadInt();
            FightSpectatorLocked = reader.ReadBoolean();
        }

    }
}
