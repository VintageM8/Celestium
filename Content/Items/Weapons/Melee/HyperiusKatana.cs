using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Celestium.Content.Items.Materials;

namespace Celestium.Content.Items.Weapons.Melee
{
	public class HyperiusKatana : ModItem
	{
		public override void SetStaticDefaults() 
		{}

		public override void SetDefaults() 
		{
			Item.damage = 21;
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
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<HyperiusBar>(), 8);
            recipe.AddIngredient(ItemID.Katana);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}