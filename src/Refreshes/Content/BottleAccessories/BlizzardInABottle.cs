using System;
using System.Reflection;
using Daybreak.Common.Features.Hooks;
using Daybreak.Common.Rendering;
using Refreshes.Common.Particles;
using Terraria.GameContent;
using Terraria.Graphics.Renderers;

namespace Refreshes.Content;

[Autoload(Side = ModSide.Client)]
internal static class BlizzardInABottle
{
    [OnLoad]
    private static void ApplyHooks()
    {
        MonoModHooks.Add(
            typeof(BlizzardInABottleJump).GetMethod("OnStarted", BindingFlags.Public | BindingFlags.Instance)!,
            OnStarted_SpawnOurParticles
        );
    }

    private static void OnStarted_SpawnOurParticles(BlizzardInABottleJump _, Player player, ref bool playSound)
    {

    }

    [ModPlayerHooks.CanShowExtraJumpVisuals]
    public static bool CancelVanillaVisuals(ModPlayerHooks.CanShowExtraJumpVisuals.Original orig, ModPlayer self, ExtraJump jump)
    {
        if (jump != ExtraJump.BlizzardInABottle)
        {
            return orig(jump);
        }
        var player = self.Player;
        Vector2 playerCenter = self.Player.Center;

        if (Main.GameUpdateCount % 2 == 0)
        {
            var dirVel = Main.rand.NextBool() ? -player.velocity : player.velocity;
            
            var particleVel = player.velocity * 0.7f + Main.rand.NextVector2Circular(5, 5);
            var particle = DustFlameParticle.RequestNew(player.Bottom, particleVel, new Color(84, 134, 237) * 0.5f, Color.White, 2, Main.rand.Next(24, 35));
            particle.LossPerFrame = 0.4f;
            particle.Swirly = false;
            ParticleEngine.PARTICLES.Add(particle);
        }
        
        
        return false;
    }

}