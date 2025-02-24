using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QwertysRandomContent.Items.Ammo
{
	public class TeleportationArrowSwap : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Teleportation Arrow (Swap)");
			Tooltip.SetDefault("Swaps your position with the enemy hit");
			
		}
		public override void SetDefaults()
		{
			item.damage = 6;
			item.ranged = true;
			item.knockBack = 2;
			item.value = 500;
			item.rare = 7;
			item.width = 12;
			item.height = 50;
			
			item.shootSpeed =6;
			
			item.consumable = true;
			item.shoot = mod.ProjectileType("TeleportationArrowPSwap");
			item.ammo = 40;
			item.maxStack = 999;
			
			
		}
		/*
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodenArrow, 200);
			recipe.AddIngredient(ItemID.PinkGel, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 200);
			recipe.AddRecipe();
		}
		*/
	}
	public class TeleportationArrowPSwap : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Teleportation Arrow");
			
			
		}
		public override void SetDefaults()
		{
			projectile.aiStyle = 1;
			projectile.width = 10;
			projectile.height = 10;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged= true;
			projectile.arrow=true;
			
			
			
		}
		public override void AI()
		{
			 Player player = Main.player[projectile.owner];
			

			
			
		}
		
		
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			if(!target.immortal&&!target.boss)
			{
			float jumpX = target.Center.X;
			float jumpY = target.Center.Y;
			Player player = Main.player[projectile.owner];
			target.position.X=player.Center.X;
			target.position.Y=player.Center.Y-30;
			
			player.position.X=jumpX;
			player.position.Y=jumpY-30;
			Main.PlaySound(25, target.position, 0);
			Main.PlaySound(25, player.position, 0);
               
            }
		}
        public override void ModifyHitPvp(Player target, ref int damage, ref bool crit)
        {
            
            float jumpX = target.Center.X;
            float jumpY = target.Center.Y;
            Player player = Main.player[projectile.owner];
            target.position.X = player.Center.X;
            target.position.Y = player.Center.Y - 30;

            player.position.X = jumpX;
            player.position.Y = jumpY - 30;
            Main.PlaySound(25, target.position, 0);
            Main.PlaySound(25, player.position, 0);

            QwertysRandomContent.UpdatePlayerPosition(target.whoAmI, target.position);
            QwertysRandomContent.UpdatePlayerPosition(player.whoAmI, player.position);



        }
        
        public override void Kill(int timeLeft)
        {
            
			

		}
		 
		
	}
	
}

