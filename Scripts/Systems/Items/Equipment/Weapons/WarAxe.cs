using System;
using Server.Engines.Harvest;

namespace Server.Items
{
    [FlipableAttribute(0x13B0, 0x13AF)]
    public class WarAxe : BaseAxe
    {
        [Constructable]
        public WarAxe()
            : base(0x13B0)
        {
            this.Weight = 8.0;
        }

        public WarAxe(Serial serial)
            : base(serial)
        {
        }

        public override int OldStrengthReq
        {
            get
            {
                return 35;
            }
        }
        public override int OldMinDamage
        {
            get
            {
                return 9;
            }
        }
        public override int OldMaxDamage
        {
            get
            {
                return 27;
            }
        }
        public override int OldSpeed
        {
            get
            {
                return 40;
            }
        }
        public override int DefHitSound
        {
            get
            {
                return 0x233;
            }
        }
        public override int DefMissSound
        {
            get
            {
                return 0x239;
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
        public override SkillName DefSkill
        {
            get
            {
                return SkillName.Macing;
            }
        }
        public override WeaponType DefType
        {
            get
            {
                return WeaponType.Bashing;
            }
        }
        public override WeaponAnimation DefAnimation
        {
            get
            {
                return WeaponAnimation.Bash1H;
            }
        }
        public override HarvestSystem HarvestSystem
        {
            get
            {
                return null;
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