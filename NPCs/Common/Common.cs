using Microsoft.Xna.Framework;
using SophmoreProject.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SophmoreProject.NPCs.Common
{
    static class CommonNpcFunctions
    {
        public static void ShootXithenProjectile( NPC npc)
        {
			npc.TargetClosest();
			if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
			{
				Vector2 position = npc.Center;

				Vector2 targetPosition = Main.player[npc.target].Center;
				Vector2 direction = targetPosition - position;
				direction.Normalize();
				float speed = 10f;
				int type = ModContent.ProjectileType<XithenProjectile>();
				int damage = npc.damage; //If the projectile is hostile, the damage passed into NewProjectile will be applied doubled, and quadrupled if expert mode, so keep that in mind when balancing projectiles
				Projectile.NewProjectile(position, direction * speed, type, damage, 0f);
			}
		}
    }
}
