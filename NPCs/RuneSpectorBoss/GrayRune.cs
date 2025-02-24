﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace QwertysRandomContent.NPCs.RuneSpectorBoss
{
    class GrayRune : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.aiStyle = -1;
            
            projectile.width = 200;
            projectile.height = 200;
            projectile.friendly = false;
            projectile.hostile = false;
            projectile.penetrate = -1;
            projectile.alpha = 255;
            projectile.tileCollide = false;


        }
        public override void AI()
        {
            projectile.velocity = new Vector2(0, 0);
            if(projectile.alpha >0)
                projectile.alpha--;
            else
                projectile.alpha=0;


        }
    }
}
