using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PreciousSwords.Projectiles;
namespace PreciousSwords.Items
{
    public class RubySword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ruby Sword");
        }
        public override void SetDefaults()
        {
            item.melee = true;
            item.damage = 20;
            item.width = 42;
            item.height = 46;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 1;
            item.knockBack = 3;
            item.shoot = ModContent.ProjectileType<RubySwordProjectile>();
            item.shootSpeed = 6;
            item.value = 10000;
            item.rare = ItemRarityID.Blue;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Ruby, 8);
            recipe.AddIngredient(ItemID.GoldBar, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
