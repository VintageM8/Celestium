using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Celestium.Content.Items.Weapons.Melee
{
	public class Eclipse : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("TestWeapon"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("'The power of the dark sun, all in your hands.'");
		}

		public override void SetDefaults() 
		{
			Item.damage = 112;
			Item.DamageType = DamageClass.Melee;
			Item.width = 20;
			Item.height = 20;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 12;
			Item.value = 100000;
			Item.rare = ItemRarityID.Lime;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
            Item.shoot = ProjectileID.MolotovFire;
            Item.shootSpeed = 15;
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
			.AddIngredient(ItemID.LunarTabletFragment, 10)
			.AddIngredient(ItemID.BrokenHeroSword)
			.AddIngredient(ItemID.ChlorophyteBar, 20)
			.AddTile(TileID.MythrilAnvil)
			.Register();
		}
	}
}
