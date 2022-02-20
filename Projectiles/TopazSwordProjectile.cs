using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PreciousSwords.Projectiles
{
	public class TopazSwordProjectile : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.melee = true;
			projectile.damage = 14;
			projectile.CloneDefaults(ProjectileID.TopazBolt);
			aiType = ProjectileID.TopazBolt;
		}

		public override bool PreKill(int timeLeft)
		{
			projectile.type = ProjectileID.TopazBolt;
			return true;
		}
	}
}
