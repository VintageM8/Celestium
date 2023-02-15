using Celestium.Content.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Celestium.Content.Items.Weapons.Melee
{
	public class DawnSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("TestWeapon"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Fires Crystal Bolts at enemies");
		}

		public override void SetDefaults() 
		{
			Item.damage = 89;
			Item.DamageType = DamageClass.Melee;
			Item.width = 20;
			Item.height = 20;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = 1;
			Item.knockBack = 12;
			Item.value = 1000000;
			Item.rare = 5;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
            Item.shoot = ProjectileID.CrystalDart;
            Item.shootSpeed = 550;
		}

		public override void AddRecipes() 
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<DawnStone>(), 8);
            recipe.AddIngredient(ModContent.ItemType<CompressedRuby>());
                recipe.AddIngredient(ItemID.SoulofMight);
                recipe.AddIngredient(ItemID.SoulofFright);
                recipe.AddIngredient(ItemID.SoulofSight);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}