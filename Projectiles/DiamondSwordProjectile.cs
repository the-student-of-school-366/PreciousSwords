using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PreciousSwords.Projectiles
{
	public class DiamondSwordProjectile : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.melee = true;
			projectile.damage = 25;
			projectile.CloneDefaults(ProjectileID.DiamondBolt);
			aiType = ProjectileID.DiamondBolt;
		}

		public override bool PreKill(int timeLeft)
		{
			projectile.type = ProjectileID.DiamondBolt;
			return true;
		}
	}
}
