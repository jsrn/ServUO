using System;
using Server;

namespace Server.Items
{
    public class FancyLoveseatNorthAddon : BaseAddon
    {
        public override BaseAddonDeed Deed { get { return new FancyLoveseatNorthDeed(); } }
        public override bool RetainDeedHue { get { return true; } }

        [Constructable]
        public FancyLoveseatNorthAddon()
        {
            AddComponent(new AddonComponent(0x9C5A), 0, 0, 0);
            AddComponent(new AddonComponent(0x9C59), 1, 0, 0);
        }

        public FancyLoveseatNorthAddon(Serial serial)
            : base(serial)
        {
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

    public class FancyLoveseatNorthDeed : BaseAddonDeed
    {
        public override BaseAddon Addon { get { return new FancyLoveseatNorthAddon(); } }
        public override int LabelNumber { get { return 1156560; } } // Fancy Loveseat (North)

        [Constructable]
        public FancyLoveseatNorthDeed()
        {
        }

        public FancyLoveseatNorthDeed(Serial serial)
            : base(serial)
        {
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