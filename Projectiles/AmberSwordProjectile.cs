using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PreciousSwords.Projectiles
{
	public class AmberSwordProjectile : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.melee = true;
			projectile.damage = 23;
			projectile.CloneDefaults(ProjectileID.AmberBolt);
			aiType = ProjectileID.AmberBolt;
		}

		public override bool PreKill(int timeLeft)
		{
			projectile.type = ProjectileID.AmberBolt;
			return true;
		}
	}
}
