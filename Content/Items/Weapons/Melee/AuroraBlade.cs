using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Celestium.Content.Items.Weapons.Melee
{
	public class AuroraBlade : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("TestWeapon"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Ancient magic and new technology were combined to make this blade");
		}

		public override void SetDefaults() 
		{
			Item.damage = 164;
			Item.DamageType = DamageClass.Melee;
			Item.width = 20;
			Item.height = 20;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 12;
			Item.value = 1000000;
			Item.rare = ItemRarityID.Purple;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
            Item.shoot = ProjectileID.FairyQueenMagicItemShot;
            Item.shootSpeed = 15;
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
			.AddIngredient(ItemID.FragmentNebula, 40)
			.AddIngredient(ItemID.TheHorsemansBlade)
			.AddTile(TileID.LunarCraftingStation)
			.Register();
		}
	}
}
