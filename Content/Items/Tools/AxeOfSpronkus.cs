using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace SpronkusMod.Content.Items.Tools
{
	public class AxeOfSpronkus : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("'The axe wielded by Spronkus Kronkus, slayer of fascists.'");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.damage = 196;
			Item.crit = 96;
			Item.DamageType = DamageClass.Melee;
			Item.width = 28;
			Item.height = 26;
			Item.useTime = 8;
			Item.useAnimation = 8;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 3f;
			Item.value = 10000;
			Item.rare = ItemRarityID.Pink;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.axe = 500;
			Item.hammer = 196;
		}

		public override void AddRecipes() {
			CreateRecipe()
			.AddIngredient(ItemID.FragmentSolar, 20)
			.AddIngredient(ItemID.FragmentNebula, 20)
			.AddIngredient(ItemID.LunarBar, 32)
			.AddTile(TileID.LunarCraftingStation)
			.Register();
		}
	}
}