using static Terraria.ModLoader.ModContent;
using Terraria.ID;
using Terraria.ModLoader;

namespace Celestium.Content.Items.Materials
{
	public class DuskBlade : ModItem
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
			Item.value = 1005375;
		}

		
        public override void AddRecipes()
        {
            CreateRecipe(1)
                .AddIngredient(ItemType<DuskShard>(), 1)
                .AddTile(TileID.Anvils)
                .Register();
        }
	}
}