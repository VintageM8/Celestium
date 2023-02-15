using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Celestium.Content.Items.Materials
{
	public class HyperiusBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			ItemID.Sets.SortingPriorityMaterials[Item.type] = 59; // influences the inventory sort order. 59 is PlatinumBar, higher is more valuable.
		}

		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 20;
			Item.maxStack = 999;
			Item.value = 750;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.IronBar, 4);
            recipe.AddIngredient(ItemID.Sapphire, 4);
            recipe.AddIngredient(ItemID.Diamond, 4);
            recipe.AddTile(TileID.Furnaces);
			recipe.Register();
		}
	}
}