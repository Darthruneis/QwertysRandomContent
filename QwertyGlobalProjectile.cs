﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace QwertysRandomContent
{
    class QwertyGlobalProjectile : GlobalProjectile
    {
        public override void SetDefaults(Projectile projectile)
        {
            if(projectile.type == 195 || projectile.type == 374 || projectile.type == 376 || projectile.type == 389 || projectile.type == 408 || projectile.type == 478 || projectile.type == 479 || projectile.type == 309 || projectile.type == 664 || projectile.type == 666 || projectile.type == 668 || projectile.type == 680)
            {
                projectile.minion = true;
            }
        }
        
       

    }
    
}
