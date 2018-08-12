using System;

namespace Server.Items
{
    [FlipableAttribute(0xf4b, 0xf4c)]
    public class DoubleAxe : BaseAxe
    {
        [Constructable]
        public DoubleAxe()
            : base(0xF4B)
        {
            this.Weight = 8.0;
        }

        public DoubleAxe(Serial serial)
            : base(serial)
        {
        }

        public override int OldStrengthReq
        {
            get
            {
                return 45;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 5;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 35;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 37;
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
                return 110;
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