using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Microsoft.Xna.Framework;

namespace SpronkusMod.Content.Items.Weapons
{
	public class TransRights : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("no way issa flag!!!!");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
            Item.damage = 31;
			Item.crit = 96;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 100;
			Item.height = 50;
			Item.scale = 0.75f;
			Item.useTime = 6;
			Item.useAnimation = 6;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true;
			Item.knockBack = 2;
			Item.value = 10000;
			Item.rare = ItemRarityID.Yellow;
			Item.UseSound = SoundID.Item11;
			Item.autoReuse = true;
			Item.shoot = 10;
			Item.shootSpeed = 18f;
			Item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes() {
			CreateRecipe()
			.AddIngredient(ItemID.Uzi)
			.AddIngredient(ItemID.SoulofLight, 10)
			.AddIngredient(ItemID.Pearlwood, 16)
			.AddTile(TileID.MythrilAnvil)
			.Register();
		}
		public override Vector2? HoldoutOffset() {
			return new Vector2(-12f, -250f);
		}
	}
}