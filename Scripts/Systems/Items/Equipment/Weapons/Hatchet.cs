using System;

namespace Server.Items
{
    [FlipableAttribute(0xF43, 0xF44)]
    public class Hatchet : BaseAxe
    {
        [Constructable]
        public Hatchet()
            : base(0xF43)
        {
            this.Weight = 4.0;
        }

        public Hatchet(Serial serial)
            : base(serial)
        {
        }

        public override int OldStrengthReq
        {
            get
            {
                return 15;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 2;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 17;
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
                return 80;
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