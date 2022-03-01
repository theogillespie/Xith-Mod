
using Microsoft.Xna.Framework;
using SophmoreProject.Dusts;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SophmoreProject.Projectiles
{
	public class XithenProjectile : ModProjectile
	{
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.SeedPlantera);
            aiType = ProjectileID.SeedPlantera;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.StrikeNPCNoInteraction(damage, knockback, -target.direction);
        }

        public override void AI()
        {
            int dust = Dust.NewDust(projectile.Center, projectile.width, projectile.height, DustID.PurpleTorch);
            Main.dust[dust].velocity /= 2f;
        }
    }
}
