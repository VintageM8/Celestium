using Terraria.ID;
using Terraria.ModLoader;


namespace Celestium.Content.Items.Weapons.Melee
{
	public class ProtoDusk : ModItem
	{
		public override void SetStaticDefaults() 
		{
		}

		public override void SetDefaults() 
		{
			Item.damage = 84;
			Item.DamageType = DamageClass.Melee;
			Item.width = 20;
			Item.height = 20;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 12;
			Item.value = 1000000;
			Item.rare = 5;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}
	}
}