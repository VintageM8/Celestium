using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Celestium.Content.Items.Materials;

namespace Celestium.Content.Items.Weapons.Melee
{
	public class HyperiusHoe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("TestWeapon"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Sickle Sub-Class");
		}

		public override void SetDefaults() 
		{
			Item.damage = 25;
			Item.DamageType = DamageClass.Melee;
			Item.width = 20;
			Item.height = 20;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 8;
			Item.value = 10000;
			Item.rare = 5;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<HyperiusBar>(), 8);
            recipe.AddIngredient(ItemID.Sickle);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}