using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Celestium.Content.Items.Weapons.Ranged
{
	public class SundererOfWorlds : ModItem
	{
		public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'I am become death, destroyer of worlds.' Converts rockets into low-yield nuclear explosives.");

        }

        public override void SetDefaults()
		{
			// Common Properties
			Item.width = 62; // Hitbox width of the item.
			Item.height = 32; // Hitbox height of the item.
			Item.scale = 1.5f;
			Item.rare = ItemRarityID.Purple; // The color that the item's name will be in-game.

			// Use Properties
			Item.useTime = 8; // The item's use time in ticks (60 ticks == 1 second.)
			Item.useAnimation = 8; // The length of the item's use animation in ticks (60 ticks == 1 second.)
			Item.useStyle = ItemUseStyleID.Shoot; // How you use the item (swinging, holding out, etc.)
			Item.autoReuse = true; // Whether or not you can hold click to automatically use it again.

			// The sound that this item plays when used.
			Item.UseSound = SoundID.DD2_BetsyFireballShot;
			{
			};

			// Weapon Properties
			Item.DamageType = DamageClass.Ranged; // Sets the damage type to ranged.
			Item.damage = 200; // Sets the item's damage. Note that projectiles shot by this weapon will use its and the used ammunition's damage added together.
			Item.knockBack = 5f; // Sets the item's knockback. Note that projectiles shot by this weapon will use its and the used ammunition's knockback added together.
			Item.noMelee = true; // So the item's animation doesn't do damage.

			// Gun Properties
			Item.shoot = ProjectileID.Celeb2RocketExplosiveLarge; // For some reason, all the guns in the vanilla source have this.
			Item.shootSpeed = 20f; // The speed of the projectile (measured in pixels per frame.)
			Item.useAmmo = AmmoID.Rocket; // The "ammo Id" of the ammo item that this weapon uses. Ammo IDs are magic numbers that usually correspond to the item id of one item that most commonly represent the ammo type.
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.ShroomiteBar, 15);
			recipe.AddIngredient(ItemID.VortexBeater, 1);
			recipe.AddIngredient(ItemID.Celeb2, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.Register();
		}
		}
	}
