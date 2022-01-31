using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using SophmoreProject.Internal;

namespace SophmoreProject.Dusts
{
	public class XithenDust : ModDust
	{
		public override void OnSpawn(Dust dust)
		{
			dust.noLight = false;
			dust.color = Palette.baseColor;
			dust.scale = 1.2f;
			dust.noGravity = true;
			dust.velocity /= 2f;
			dust.alpha = 100;
		}

		public override bool Update(Dust dust)
		{
			dust.position += dust.velocity;
			dust.rotation += dust.velocity.X;
			Lighting.AddLight(10, 10, Palette.lightColor.R, Palette.lightColor.G, Palette.lightColor.B);

			return false;
		}
	}
}