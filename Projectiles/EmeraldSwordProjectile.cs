using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PreciousSwords.Projectiles
{
    public class EmeraldSwordProjectile : ModProjectile
    {
		public override void SetDefaults()
		{
			projectile.melee = true;
			projectile.damage = 16;
			projectile.CloneDefaults(ProjectileID.EmeraldBolt);
			aiType = ProjectileID.EmeraldBolt;
		}

		public override bool PreKill(int timeLeft)
		{
			projectile.type = ProjectileID.EmeraldBolt;
			return true;
		}
	}
}
