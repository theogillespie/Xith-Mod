using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using SophmoreProject.Internal;

namespace SophmoreProject.Tiles
{
	public class XithenOre : ModTile
	{
		public override void SetDefaults()
		{
			TileID.Sets.Ore[Type] = true;
			Main.tileSpelunker[Type] = true; // The tile will be affected by spelunker highlighting
			Main.tileValue[Type] = 410; // Metal Detector value, see https://terraria.gamepedia.com/Metal_Detector
			Main.tileShine2[Type] = true; // Modifies the draw color slightly.
			Main.tileShine[Type] = 975; // How often tiny dust appear off this tile. Larger is less frequently
			//Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;

			

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("XithenOre");
			AddMapEntry(Palette.baseColor, name);

			dustType = DustID.AmethystBolt;
			
			drop = ModContent.ItemType<Items.Materials.XithenOreItem>();
			soundType = SoundID.Tink;
			soundStyle = 1;


		
			
		}
	}
}