using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace SpronkusMod.Content.Items.Ammo
{
    public class SpronkusBullet : ModItem
    {
        public override void SetStaticDefaults() {
			Tooltip.SetDefault("Add description");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
		}
        public override void SetDefaults()
        {
            Item.damage = 12;
            Item.width = 8;
            Item.height = 8;
            Item.DamageType = DamageClass.Ranged;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.knockBack = 1.2f;
            Item.value = 12;
            Item.rare = ItemRarityID.Purple;
            Item.shoot = ModContent.ProjectileType<Projectiles.SpronkusProjectile>();
            Item.shootSpeed = 16f;
            Item.ammo = AmmoID.Bullet;
        }
        public override void AddRecipes() {
			var recipe = ModContent.GetInstance<Items.Ammo.SpronkusBullet>();
            recipe.CreateRecipe()
				.AddIngredient(ItemID.MusketBall, 70)
                .AddIngredient(ItemID.GelBalloon, 5)
				.AddTile(TileID.Anvils)
				.Register();
		}
    }
}
