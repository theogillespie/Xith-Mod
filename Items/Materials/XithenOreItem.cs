using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;
using SophmoreProject.Internal;

namespace SophmoreProject.Items.Materials
{

	public class XithenOreItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Xithricite Ore");
			Tooltip.SetDefault("A super-dense crystalline metal embeded in stone");
		}

		public override void SetDefaults()
		{
			item.maxStack = 99;                 //this is where you set the max stack of item
			item.consumable = false;           //this make that the item is consumable when used
			item.width = 32;
			item.height = 32;
			item.value = 400;
			item.rare = ItemRarityID.Blue;
			
		}

	}
}