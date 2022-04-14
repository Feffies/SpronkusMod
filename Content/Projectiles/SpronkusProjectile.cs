using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace SpronkusMod.Content.Projectiles
{
    public class SpronkusProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spronkus Projectile");
            ProjectileID.Sets.CultistIsResistantTo[Projectile.type] = true;
        }
    }
}
