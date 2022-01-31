using Terraria.ID;
using Terraria.ModLoader;

namespace SophmoreProject.Items.Weapons
{
	public class BasicXithriciteSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Basic Xith Sword"); 
			Tooltip.SetDefault("The sword seems weak, but it has a strange humming power within");
		}

		public override void SetDefaults() 
		{
			item.damage = 20;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Materials.Xithricite>(), 7);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}