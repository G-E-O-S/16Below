using System;

namespace Server.Items
{
    [FlipableAttribute(0x13b4, 0x13b3)]
    public class Club : BaseBashing
    {
        [Constructable]
        public Club()
            : base(0x13B4)
        {
            this.Weight = 9.0;
        }

        public Club(Serial serial)
            : base(serial)
        {
        }

        public override int OldStrengthReq
        {
            get
            {
                return 10;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 8;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 24;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 40;
            }
        }
        public override int InitMinHits
        {
            get
            {
                return 31;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 40;
            }
        }
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}