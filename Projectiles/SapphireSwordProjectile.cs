using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PreciousSwords.Projectiles
{
	public class SapphireSwordProjectile : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.melee = true;
			projectile.damage = 18;
			projectile.CloneDefaults(ProjectileID.SapphireBolt);
			aiType = ProjectileID.SapphireBolt;
		}

		public override bool PreKill(int timeLeft)
		{
			projectile.type = ProjectileID.SapphireBolt;
			return true;
		}
	}
}
