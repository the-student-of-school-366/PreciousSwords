using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PreciousSwords.Projectiles
{
	public class RubySwordProjectile : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.melee = true;
			projectile.damage = 20;
			projectile.CloneDefaults(ProjectileID.RubyBolt);
			aiType = ProjectileID.RubyBolt;
		}

		public override bool PreKill(int timeLeft)
		{
			projectile.type = ProjectileID.RubyBolt;
			return true;
		}
	}
}
