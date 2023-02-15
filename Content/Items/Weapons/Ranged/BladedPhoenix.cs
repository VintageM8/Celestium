using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Celestium.Content.Items.Weapons.Ranged
{
	public class BladedPhoenix : ModItem
	{

		public override void SetStaticDefaults() {
			Tooltip.SetDefault("You put a blade on the Phoenix Blaster and now it hits stuff! Congratulations!.");

	}		

		public override void SetDefaults() {
			Item.damage = 30; // Sets the item's damage. Note that projectiles shot by this weapon will use its and the used ammunition's damage added together.
			Item.DamageType = DamageClass.Ranged; // sets the damage type to ranged
			Item.width = 40; // hitbox width of the item
			Item.height = 20; // hitbox height of the item
			Item.useTime = 20; // The item's use time in ticks (60 ticks == 1 second.)
			Item.useAnimation = 20; // The length of the item's use animation in ticks (60 ticks == 1 second.)
			Item.useStyle = ItemUseStyleID.Shoot; // how you use the item (swinging, holding out, etc)
			Item.knockBack = 1; // Sets the item's knockback. Note that projectiles shot by this weapon will use its and the used ammunition's knockback added together.
			Item.value = 1000000; // how much the item sells for (measured in copper)
			Item.rare = ItemRarityID.Purple; // the color that the item's name will be in-game
			Item.UseSound = SoundID.Item11; // The sound that this item plays when used.
			Item.autoReuse = true; // if you can hold click to automatically use it again
			Item.shoot = 10; //idk why but all the guns in the vanilla source have this
			Item.shootSpeed = 25f; // the speed of the projectile (measured in pixels per frame)
			Item.useAmmo = AmmoID.Bullet; // The "ammo Id" of the ammo item that this weapon uses. Note that this is not an item Id, but just a magic value.
		}

		public override void AddRecipes() {
			CreateRecipe(1)
			.AddIngredient(ItemID.PhoenixBlaster)
			.AddIngredient(ItemID.HellstoneBar, 5)
            .AddIngredient(ItemID.MoltenHamaxe)
			.AddTile(TileID.Anvils)
			.Register();
		}

public override Vector2? HoldoutOffset() {
		return new Vector2(0, 0);

	    }
    }
}