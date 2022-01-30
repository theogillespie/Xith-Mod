using Terraria.ID;
using Terraria.ModLoader;

namespace SophmoreProject.Items
{

	
	public class Xithricite : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Xithricite");
			Tooltip.SetDefault("A super-dense crystalline metal");
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

		/*
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
	}
}