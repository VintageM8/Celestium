using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Celestium.Content.Items.Accessories
{
    [AutoloadEquip(EquipType.Wings)]
    public class VoidWings : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("An ancient wing forged from celestial ingredients.");

        }

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 20;
            Item.value = 100000000;
            Item.rare = ItemRarityID.Purple;
            Item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.wingTimeMax = 600;
        }

        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
            ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 1f;
            ascentWhenRising = 1.15f;
            maxCanAscendMultiplier = 1f;
            maxAscentMultiplier = 3f;
            constantAscend = 1.135f;
        }

        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            speed = 10f;
            acceleration *= 2.5f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SoulofFlight, 20);
            recipe.AddIngredient(ItemID.FragmentSolar, 40);
            recipe.AddIngredient(ItemID.Spear);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }
    }
}
