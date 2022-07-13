﻿namespace Stump.DofusProtocol.Messages
{
    using System;
    using System.Linq;
    using System.Text;
    using Stump.DofusProtocol.Types;
    using Stump.Core.IO;

    [Serializable]
    public class ExchangeObjectUseInWorkshopMessage : Message
    {
        public const uint Id = 6004;
        public override uint MessageId
        {
            get { return Id; }
        }
        public uint ObjectUID { get; set; }
        public int Quantity { get; set; }

        public ExchangeObjectUseInWorkshopMessage(uint objectUID, int quantity)
        {
            this.ObjectUID = objectUID;
            this.Quantity = quantity;
        }

        public ExchangeObjectUseInWorkshopMessage() { }

        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUInt(ObjectUID);
            writer.WriteVarInt(Quantity);
        }

        public override void Deserialize(IDataReader reader)
        {
            ObjectUID = reader.ReadVarUInt();
            Quantity = reader.ReadVarInt();
        }

    }
}
