using System;

namespace Server.Items
{
    [FlipableAttribute(0x13ec, 0x13ed)]
    public class RingmailChest : BaseArmor
    {
        [Constructable]
        public RingmailChest()
            : base(0x13EC)
        {
            this.Weight = 15.0;
        }

        public RingmailChest(Serial serial)
            : base(serial)
        {
        }


        public override int InitMinHits
        {
            get
            {
                return 40;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 50;
            }
        }
        public override int OldStrReq
        {
            get
            {
                return 20;
            }
        }
        public override int OldDexBonus
        {
            get
            {
                return -2;
            }
        }
        public override int ArmorBase
        {
            get
            {
                return 22;
            }
        }
        public override ArmorMaterialType MaterialType
        {
            get
            {
                return ArmorMaterialType.Ringmail;
            }
        }
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            if (this.Weight == 1.0)
                this.Weight = 15.0;
        }
    }
}