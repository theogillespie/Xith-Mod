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
			dust.noLight = true;
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
			float strength = dust.scale / 2f;
			Lighting.AddLight((int)(dust.position.X / 16f), (int)(dust.position.Y / 16f), Palette.baseColor.R / 255f * 0.5f * strength, Palette.baseColor.G / 255f * 0.5f * strength, Palette.baseColor.B / 255f * 0.5f * strength);
			return false;
		}
		
	}
}