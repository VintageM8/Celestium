using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Celestium.Content.Items.Materials;

namespace Celestium.Content.Items.Weapons.Melee
{
	public class Corrosis : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Corrosis"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("An acidic blade forged from scrap.");
		}

		public override void SetDefaults() 
		{
			Item.damage = 37;
			Item.DamageType = DamageClass.Melee;
			Item.width = 20;
			Item.height = 20;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 7;
			Item.value = 10000;
			Item.rare = 3;
			Item.UseSound = SoundID.Item3;
			Item.autoReuse = true;
		}

		
		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<KcirbiteBar>(), 5);
            recipe.AddIngredient(ItemID.Muramasa);
            recipe.AddIngredient(ItemID.Coral, 5);
			recipe.AddIngredient(ItemID.Trident);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
        }
	}
}