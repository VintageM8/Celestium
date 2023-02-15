using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Celestium.Content.Items.Materials
{
	public class CompressedRuby : ModItem
	{
		public override void SetStaticDefaults()
		{
			ItemID.Sets.SortingPriorityMaterials[Item.type] = 69; 
		}

		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 20;
			Item.maxStack = 999;
			Item.value = 750;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.autoReuse = true;
			Item.consumable = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Ruby, 9);
            recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}