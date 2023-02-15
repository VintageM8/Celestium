using Celestium.Content.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Celestium.Content.Items.Weapons.Melee
{
	public class DuskShortsword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("TestWeapon"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Fires bolts of Cursed Flame at enemies");
		}

		public override void SetDefaults() 
		{
			Item.damage = 64;
			Item.DamageType = DamageClass.Melee;
			Item.width = 20;
			Item.height = 20;
			Item.useTime = 35;
			Item.useAnimation = 10;
			Item.useStyle = 3;
			Item.knockBack = 12;
			Item.value = 1000000;
			Item.rare = 5;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
            Item.shoot = ProjectileID.CursedDart;
            Item.shootSpeed = 100;
		}

		public override void AddRecipes() 
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<DuskStone>(), 2);
            recipe.AddIngredient(ItemID.Wood, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}