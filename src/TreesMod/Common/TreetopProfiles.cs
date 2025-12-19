using Daybreak.Common.Features.Hooks;
using JetBrains.Annotations;
using ReLogic.Content;
using System.Collections.Generic;
using Terraria.GameContent;

namespace TreesMod.Common;

public record struct TreetopVariation(int Width, int Height);

public record struct TreetopStyleProfile(Asset<Texture2D> TopTexture, Asset<Texture2D> BranchTexture, TreetopVariation[]? Variations = null) {
    public TreetopVariation GetVariation(int frame) {
        if (Variations != null && frame >= 0 && frame < Variations.Length)
            return Variations[frame];
        
        return new TreetopVariation(82, 82); //default treetop width
    }
}

public static class TreetopProfiles {
    public static readonly Dictionary<int, TreetopStyleProfile> Profiles = new();
    
    [OnLoad, UsedImplicitly]
    static void Load() {
        // Forest Tree Style 0
        Profiles[0] = new TreetopStyleProfile(
            TopTexture: TextureAssets.TreeTop[0],
            BranchTexture: TextureAssets.TreeBranch[0],
            Variations: new TreetopVariation[] {
                new(82, 82),
                new(82, 82),
                new(82, 82)
            }
        );
    }

    public static bool TryGetProfile(int style, out TreetopStyleProfile profile) 
        => Profiles.TryGetValue(style, out profile);
}