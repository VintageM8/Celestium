using Celestium.Content.Items.Materials;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Celestium.Content.Items.Weapons.Ranged
{
	public class DawnGreatbow : ModItem
	{

		

		public override void SetDefaults() {
			Item.damage = 83; // Sets the item's damage. Note that projectiles shot by this weapon will use its and the used ammunition's damage added together.
			Item.DamageType = DamageClass.Ranged;
			Item.width = 40; // hitbox width of the item
			Item.height = 40; // hitbox height of the item
			Item.useTime = 20; // The item's use time in ticks (60 ticks == 1 second.)
			Item.useAnimation = 20; // The length of the item's use animation in ticks (60 ticks == 1 second.)
			Item.useStyle = ItemUseStyleID.Shoot; // how you use the item (swinging, holding out, etc)
			Item.noMelee = true; //so the item's animation doesn't do damage
			Item.knockBack = 4; // Sets the item's knockback. Note that projectiles shot by this weapon will use its and the used ammunition's knockback added together.
			Item.value = 100000; // how much the item sells for (measured in copper)
			Item.rare = ItemRarityID.Green; // the color that the item's name will be in-game
			Item.UseSound = SoundID.Item11; // The sound that this item plays when used.
			Item.autoReuse = true; // if you can hold click to automatically use it again
			Item.shoot = 10; //idk why but all the guns in the vanilla source have this
			Item.shootSpeed = 20f; // the speed of the projectile (measured in pixels per frame)
			Item.useAmmo = AmmoID.Arrow; // The "ammo Id" of the ammo item that this weapon uses. Note that this is not an item Id, but just a magic value.
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<DawnStone>(), 10);
			recipe.AddIngredient(ModContent.ItemType<CompressedRuby>());
			recipe.AddIngredient(ItemID.DaedalusStormbow);
			recipe.AddIngredient(ItemID.SoulofMight);
            recipe.AddIngredient(ItemID.SoulofFright);
            recipe.AddIngredient(ItemID.SoulofSight);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}

public override Vector2? HoldoutOffset() {
		return new Vector2(0, 0);

	    }
    }
}