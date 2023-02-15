using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace Celestium.Content.Items.Materials
{
	public class Viridistone : ModItem
	{
		public override void SetDefaults() 
		{
			Item.width = 12;
			Item.height = 12;
			Item.maxStack = 999;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.consumable = true;
		}

		public override void AddRecipes() 
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.StoneBlock, 10);
            recipe.AddIngredient(ItemID.Ruby, 1);
			recipe.AddTile(TileID.Furnaces);
			recipe.Register();


		}

	}

}