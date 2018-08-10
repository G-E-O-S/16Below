using System;

namespace Server.Items
{
    [FlipableAttribute(0x1451, 0x1456)]
    public class BoneHelm : BaseArmor
    {
        [Constructable]
        public BoneHelm()
            : base(0x1451)
        {
            this.Weight = 3.0;
        }

        public BoneHelm(Serial serial)
            : base(serial)
        {
        }

        public override int InitMinHits
        {
            get
            {
                return 25;
            }
        }
        public override int InitMaxHits
        {
            get
            {
                return 30;
            }
        }
        public override int OldStrReq
        {
            get
            {
                return 40;
            }
        }
        public override int ArmorBase
        {
            get
            {
                return 30;
            }
        }
        public override ArmorMaterialType MaterialType
        {
            get
            {
                return ArmorMaterialType.Plate;
            }
        }
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);

            if (this.Weight == 1.0)
                this.Weight = 3.0;
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}