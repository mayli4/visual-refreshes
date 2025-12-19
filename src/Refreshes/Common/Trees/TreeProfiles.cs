using System;
using System.Collections.Generic;
using Daybreak.Common.Features.Hooks;
using JetBrains.Annotations;
using ReLogic.Content;
using Terraria.GameContent;

namespace Refreshes.Common;

public record struct TreetopVariation(
    int Width,
    int Height,
    Vector2 OriginOffset = default
);

public readonly record struct TreeStyleProfile(
    int PaintIdx,
    Asset<Texture2D> TopTexture,
    Asset<Texture2D> BranchTexture,
    TreetopVariation[] Variations
)
{
    public TreetopVariation GetVariation(int frame)
    {
        return Variations[frame % Variations.Length];
    }

    public Texture2D GetTop(int paintColor)
    {
        if (paintColor == 0)
        {
            return TopTexture.Value;
        }

        return Main.instance.TilePaintSystem.TryGetTreeTopAndRequestIfNotReady(PaintIdx, 0, paintColor) ?? TopTexture.Value;
    }
}

public static class TreeProfiles
{
    private const int treetop_resize_buffer = 128;

    private static readonly List<TreeStyleProfile> profiles = [];
    
    private static Asset<Texture2D>[]? oldTreeTops;

    public static TreeStyleProfile GetTreeProfile(int style)
    {
        return profiles[style];
    }
    
    [ModSystemHooks.ResizeArrays]
    private static void ResizeTreeTops()
    {
        oldTreeTops ??= TextureAssets.TreeTop;
        Array.Resize(ref TextureAssets.TreeTop, treetop_resize_buffer);
    }

    [OnUnload]
    private static void RestoreVanillaTreeTops()
    {
        profiles.Clear();

        if (oldTreeTops is not null)
        {
            TextureAssets.TreeTop = oldTreeTops;
        }
    }

    [OnLoad]
    private static void LoadDefaultProfiles()
    {
        // Load in default data for vanilla tree styles so we always have every
        // vanilla profile filled in, even if we haven't set any variations for
        // them yet.
        for (var i = 0; i < (int)VanillaTreeStyle.Count; i++)
        {
            profiles[i] = new TreeStyleProfile(
                PaintIdx: i,
                TopTexture: TextureAssets.TreeTop[i],
                BranchTexture: TextureAssets.TreeBranch[i],
                Variations: []
            );
        }

        foreach (var forest in VanillaTreeStyles.Forest)
        {
            var style = (int)forest;

            profiles[style] = new TreeStyleProfile(
                PaintIdx: style,
                TopTexture: TextureAssets.TreeTop[style],
                BranchTexture: TextureAssets.TreeBranch[style],
                Variations:
                [
                    new TreetopVariation(80, 80, Vector2.Zero),
                    new TreetopVariation(80, 80, Vector2.Zero),
                    new TreetopVariation(80, 80, Vector2.Zero),
                ]
            );
        }

        foreach (var vanity in VanillaTreeStyles.Vanity)
        {
            var style = (int)vanity;

            profiles[style] = new TreeStyleProfile(
                PaintIdx: style,
                TopTexture: TextureAssets.TreeTop[style],
                BranchTexture: TextureAssets.TreeBranch[style],
                Variations:
                [
                    new TreetopVariation(118, 96, Vector2.Zero),
                    new TreetopVariation(118, 96, Vector2.Zero),
                    new TreetopVariation(118, 96, Vector2.Zero),
                ]
            );
        }

        foreach (var boreal in new[] { VanillaTreeStyle.Boreal3, VanillaTreeStyle.Boreal4, VanillaTreeStyle.Boreal5 })
        {
            var style = (int)boreal;

            profiles[style] = new TreeStyleProfile(
                PaintIdx: style,
                TopTexture: TextureAssets.TreeTop[style],
                BranchTexture: TextureAssets.TreeBranch[style],
                Variations:
                [
                    new TreetopVariation(80, 80, Vector2.Zero),
                    new TreetopVariation(80, 80, Vector2.Zero),
                    new TreetopVariation(80, 80, Vector2.Zero),
                ]
            );
        }

        foreach (var jungle in new[] { VanillaTreeStyle.Jungle1 })
        {
            var style = (int)jungle;

            profiles[style] = new TreeStyleProfile(
                PaintIdx: style,
                TopTexture: TextureAssets.TreeTop[style],
                BranchTexture: TextureAssets.TreeBranch[style],
                Variations:
                [
                    new TreetopVariation(114, 96, Vector2.Zero),
                    new TreetopVariation(114, 96, Vector2.Zero),
                    new TreetopVariation(114, 96, Vector2.Zero),
                ]
            );
        }

        foreach (var jungle in new[] { VanillaTreeStyle.Jungle2, VanillaTreeStyle.Jungle3 })
        {
            var style = (int)jungle;

            profiles[style] = new TreeStyleProfile(
                PaintIdx: style,
                TopTexture: TextureAssets.TreeTop[style],
                BranchTexture: TextureAssets.TreeBranch[style],
                Variations:
                [
                    new TreetopVariation(116, 96, Vector2.Zero),
                    new TreetopVariation(116, 96, Vector2.Zero),
                    new TreetopVariation(116, 96, Vector2.Zero),
                ]
            );
        }

        foreach (var corruption in VanillaTreeStyles.Corruption)
        {
            var style = (int)corruption;

            profiles[style] = new TreeStyleProfile(
                PaintIdx: style,
                TopTexture: TextureAssets.TreeTop[style],
                BranchTexture: TextureAssets.TreeBranch[style],
                Variations:
                [
                    new TreetopVariation(80, 80, Vector2.Zero),
                    new TreetopVariation(80, 80, Vector2.Zero),
                    new TreetopVariation(80, 80, Vector2.Zero),
                ]
            );
        }

        foreach (var crimson in VanillaTreeStyles.Crimson)
        {
            var style = (int)crimson;

            profiles[style] = new TreeStyleProfile(
                PaintIdx: style,
                TopTexture: TextureAssets.TreeTop[style],
                BranchTexture: TextureAssets.TreeBranch[style],
                Variations:
                [
                    new TreetopVariation(80, 80, Vector2.Zero),
                    new TreetopVariation(80, 80, Vector2.Zero),
                    new TreetopVariation(80, 80, Vector2.Zero),
                ]
            );
        }

        foreach (var glowingMushroom in VanillaTreeStyles.GlowingMushroom)
        {
            var style = (int)glowingMushroom;

            profiles[style] = new TreeStyleProfile(
                PaintIdx: style,
                TopTexture: TextureAssets.TreeTop[style],
                BranchTexture: TextureAssets.TreeBranch[style],
                Variations:
                [
                    new TreetopVariation(80, 80, Vector2.Zero),
                    new TreetopVariation(80, 80, Vector2.Zero),
                    new TreetopVariation(80, 80, Vector2.Zero),
                ]
            );
        }
    }
}
