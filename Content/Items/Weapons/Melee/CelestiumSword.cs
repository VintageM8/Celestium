using Terraria.ID;
using Terraria.ModLoader;
using Celestium.Content.Items.Materials;

namespace Celestium.Content.Items.Weapons.Melee
{
	public class CelestiumSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("TestWeapon"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A blade forged of a metal from beyond the stars");
		}

		public override void SetDefaults() 
		{
			Item.damage = 41;
			Item.DamageType = DamageClass.Melee;
			Item.width = 20;
			Item.height = 20;
			Item.useTime = 10;
			Item.useAnimation = 10;
			Item.useStyle = 1;
			Item.knockBack = 7;
			Item.value = 10000;
			Item.rare = 5;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			CreateRecipe(1)
			.AddIngredient(ModContent.ItemType<CelestiumBar>(), 8)
            .AddIngredient(ItemID.Wood, 2)
			.AddTile(TileID.Anvils)
			.Register();
		}
	}
}