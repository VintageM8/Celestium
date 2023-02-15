using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Celestium.Content.Items.Materials;

namespace Celestium.Content.Items.Weapons.Melee
{
	public class DynamicSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("DynamicSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("The first sword with DynamicTools compatibility, can be dissassembled into its parts.");
		}

		public override void SetDefaults() 
		{
			Item.damage = 50;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.Hellforge);
			recipe.Register();
			recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<DynamicHilt>());
			recipe.AddIngredient(ModContent.ItemType<DynamicBlade>());
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}