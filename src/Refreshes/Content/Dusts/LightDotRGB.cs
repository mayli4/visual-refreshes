using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;

namespace Refreshes.Content.Dusts;

internal class LightDotRGB : ModDust
{
    public override string? Texture => null;

    public override void OnSpawn(Dust dust)
    {
        var desiredVanillaDustTexture = DustID.FireworksRGB;
        var frameX = desiredVanillaDustTexture * 10 % 1000;
        var frameY = desiredVanillaDustTexture * 10 / 1000 * 30 + Main.rand.Next(3) * 10;
        dust.frame = new Rectangle(frameX, frameY, 8, 8);
    }

    public override bool Update(Dust dust)
    {
        dust.scale -= dust.fadeIn;

        if (!dust.noLight && !dust.noLightEmittence)
        {
            Lighting.AddLight(dust.position, dust.color.ToVector3() * dust.scale);
        }
        if (dust.noGravity)
        {
            dust.velocity *= 0.93f;
        }
        else
        {
            dust.velocity *= 0.95f;
            dust.scale -= 0.0025f;
        }

        return true;
    }

    public override Color? GetAlpha(Dust dust, Color lightColor)
    {
        var result = new Color(lightColor.ToVector3() * dust.color.ToVector3())
        {
            A = 25
        };
        return result;
    }
}
