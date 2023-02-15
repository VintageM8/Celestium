using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Celestium.Content.Items.Materials
{
	public class DuskStone : ModItem
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
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.autoReuse = true;
			Item.consumable = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SoulofNight, 4);
            recipe.AddIngredient(ItemID.HallowedBar, 2);
            recipe.AddIngredient(ItemID.SoulofLight, 2);
			recipe.AddIngredient(ItemID.ShadowScale, 3);
            recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}