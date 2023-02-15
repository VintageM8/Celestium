using Terraria.ID;
using Terraria.ModLoader;

namespace Celestium.Content.Items.Materials
{
	public class LimoniteBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			ItemID.Sets.SortingPriorityMaterials[Item.type] = 69; // influences the inventory sort order. 59 is PlatinumBar, higher is more valuable.
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
			CreateRecipe(1)
			.AddIngredient(ModContent.ItemType<LimoniteOre>(), 4)
            .AddTile(TileID.Furnaces)
			.Register();
		}
	}
}