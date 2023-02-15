using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria;
using Celestium.Content.Items.Materials;

namespace Celestium.Content.Items.Weapons.Magic
{
	public class SuperchargedWand : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("So this was meant to be for onehundreddays but I couldn't figure out how to use Limonite soo...");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.damage = 25;
			Item.DamageType = DamageClass.Magic; // Makes the damage register as magic. If your item does not have any damage type, it becomes true damage (which means that damage scalars will not affect it). Be sure to have a damage type.
			Item.width = 34;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing; // Makes the player use a 'Shoot' use style for the Item.
			Item.noMelee = true; // Makes the item not do damage with it's melee hitbox.
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = ItemRarityID.LightRed;
			Item.UseSound = SoundID.Item71;
			Item.autoReuse = true;
			Item.shoot = ProjectileID.AmberBolt; // Shoot a black bolt, also known as the projectile shot from the onyx blaster.
			Item.shootSpeed = 5; // How fast the item shoots the projectile.
			Item.crit = 32; // The percent chance at hitting an enemy with a crit, plus the default amount of 4.
			Item.mana = 9; // This is how much mana the item uses.
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Meteorite, 17);
			recipe.AddIngredient(ItemID.WandofSparking, 1);
			recipe.AddIngredient(ModContent.ItemType<LimoniteOre>(), 23);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}