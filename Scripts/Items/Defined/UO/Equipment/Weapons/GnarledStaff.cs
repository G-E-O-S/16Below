using System;

namespace Server.Items
{
    [FlipableAttribute(0x13F8, 0x13F9)]
    public class GnarledStaff : BaseStaff
    {
        [Constructable]
        public GnarledStaff()
            : base(0x13F8)
        {
            this.Weight = 3.0;
        }

        public GnarledStaff(Serial serial)
            : base(serial)
        {
        }

        public override int OldStrengthReq
        {
            get
            {
                return 20;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 10;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 30;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 33;
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
                return 50;
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