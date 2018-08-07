using System;

namespace Server.Items
{
    [FlipableAttribute(0x13FF, 0x13FE)]
    public class Katana : BaseSword
    {
        [Constructable]
        public Katana()
            : base(0x13FF)
        {
            this.Weight = 6.0;
        }

        public Katana(Serial serial)
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
                return 5;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 26;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 58;
            }
        }
        public override int DefHitSound
        {
            get
            {
                return 0x23B;
            }
        }
        public override int DefMissSound
        {
            get
            {
                return 0x23A;
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
                return 90;
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