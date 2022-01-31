using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace SophmoreProject.Items.Weapons
{
	public class EnchantedXithriciteSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Enchanted Xith Sword"); 
			Tooltip.SetDefault("An upgradaded version of a basic sword, this sword has gained the power to utilize strange magics");
		}

		public override void SetDefaults() 
		{
			item.damage = 35;
			item.melee = true;
			item.width = 100;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;

			item.useStyle = ItemUseStyleID.SwingThrow;
			item.shoot = ProjectileID.AmethystBolt;
			item.shootSpeed = 8f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<BasicXithriciteSword>(), 1);
			recipe.AddIngredient(ModContent.ItemType<Items.Materials.Xithricite>(), 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.NextBool(3))
			{
				Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.PurpleCrystalShard);
			}
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 target = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY);
			float ceilingLimit = target.Y;
			if (ceilingLimit > player.Center.Y - 200f)
			{
				ceilingLimit = player.Center.Y - 200f;
			}
			for (int i = 0; i < 3; i++)
			{
				position = player.Center + new Vector2((-(float)Main.rand.Next(0, 401) * player.direction), -600f);
				position.Y -= (100 * i);
				Vector2 heading = target - position;
				if (heading.Y < 0f)
				{
					heading.Y *= -1f;
				}
				if (heading.Y < 20f)
				{
					heading.Y = 20f;
				}
				heading.Normalize();
				heading *= new Vector2(speedX, speedY).Length();
				speedX = heading.X;
				speedY = heading.Y + Main.rand.Next(-40, 41) * 0.02f;
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, (int)(damage * .2f), knockBack, player.whoAmI, 0f, ceilingLimit);
			}
			return false;
		}
	}
}