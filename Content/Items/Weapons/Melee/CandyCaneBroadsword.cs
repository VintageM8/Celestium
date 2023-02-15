using Terraria.ID;
using Terraria.ModLoader;

namespace Celestium.Content.Items.Weapons.Melee
{
	public class CandyCaneBroadsword : ModItem
	{
		public override void SetStaticDefaults() 
		{}

		public override void SetDefaults() 
		{
			Item.damage = 76;
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
			CreateRecipe(1)
			.AddIngredient(ModContent.ItemType<TestWeapon>())
            .AddIngredient(ItemID.CandyCaneSword)
			.AddTile(TileID.Anvils)
			.Register();
		}
	}
}