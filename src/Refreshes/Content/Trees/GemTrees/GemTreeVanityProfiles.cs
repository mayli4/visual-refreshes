using System.Collections.Generic;
using ReLogic.Content;
using Terraria.ID;

namespace Refreshes.Content;

public readonly record struct GemTreeVanityDescription(
    Asset<Texture2D> Trunk,
    Asset<Texture2D>? TrunkGems,
    Asset<Texture2D> Branches,
    Asset<Texture2D>? BranchesGems,
    Asset<Texture2D> Tops,
    Asset<Texture2D>? TopsGems
);

public readonly record struct GemTreeVanitySaplingDescription(
    Asset<Texture2D> Sapling,
    Asset<Texture2D>? SaplingGems
);

public readonly record struct GemTreeVanityProfile(
    GemTreeVanityDescription Purity,
    GemTreeVanitySaplingDescription PuritySaplings,
    Dictionary<int, GemTreeVanityDescription> Biomes,
    Dictionary<int, GemTreeVanitySaplingDescription> SaplingBiomes
)
{
    public GemTreeVanityDescription GetDescription(int biomeId)
    {
        if (biomeId == BiomeConversionID.Purity || biomeId == -1)
        {
            return Purity;
        }

        return Biomes.GetValueOrDefault(biomeId, Purity);
    }

    public GemTreeVanitySaplingDescription GetSaplingDescription(int biomeId)
    {
        if (biomeId == BiomeConversionID.Purity || biomeId == -1)
        {
            return PuritySaplings;
        }

        return SaplingBiomes.GetValueOrDefault(biomeId, PuritySaplings);
    }
}

public static class GemTreeVanityProfiles
{
    public static readonly GemTreeVanityProfile RUBY = new(
        Purity: new GemTreeVanityDescription(
            Trunk: Assets.Images.Content.GemTrees.PurityGemTree_Stone.Asset,
            TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Ruby.Asset,
            Branches: Assets.Images.Content.GemTrees.PurityGemTree_Stone_Branches.Asset,
            BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Ruby_Branches.Asset,
            Tops: Assets.Images.Content.GemTrees.PurityGemTree_Stone_TreeTops.Asset,
            TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Ruby_Tops.Asset
        ),
        PuritySaplings: new GemTreeVanitySaplingDescription(
            Sapling: Assets.Images.Content.GemTrees.PurityGemTree_Stone_Saplings.Asset,
            SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
        ),
        Biomes: new Dictionary<int, GemTreeVanityDescription>
        {
            [BiomeConversionID.Corruption] = new(
                Trunk: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone.Asset,
                TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Ruby.Asset,
                Branches: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone_Branches.Asset,
                BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Ruby_Branches.Asset,
                Tops: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone_TreeTops.Asset,
                TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Ruby_Tops.Asset
            ),
            [BiomeConversionID.Crimson] = new(
                Trunk: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone.Asset,
                TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Ruby.Asset,
                Branches: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone_Branches.Asset,
                BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Ruby_Branches.Asset,
                Tops: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone_TreeTops.Asset,
                TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Ruby_Tops.Asset
            ),
            [BiomeConversionID.Hallow] = new(
                Trunk: Assets.Images.Content.GemTrees.HallowGemTree_Stone.Asset,
                TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Ruby.Asset,
                Branches: Assets.Images.Content.GemTrees.HallowGemTree_Stone_Branches.Asset,
                BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Ruby_Branches.Asset,
                Tops: Assets.Images.Content.GemTrees.HallowGemTree_Stone_TreeTops.Asset,
                TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Ruby_Tops.Asset
            ),
        },
        SaplingBiomes: new Dictionary<int, GemTreeVanitySaplingDescription>
        {
            [BiomeConversionID.Corruption] = new(
                Sapling: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone_Saplings.Asset,
                SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
            ),
            [BiomeConversionID.Crimson] = new(
                Sapling: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone_Saplings.Asset,
                SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
            ),
            [BiomeConversionID.Hallow] = new(
                Sapling: Assets.Images.Content.GemTrees.HallowGemTree_Stone_Saplings.Asset,
                SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
            ),
        }
    );

    public static readonly GemTreeVanityProfile DIAMOND = new(
        Purity: new GemTreeVanityDescription(
            Trunk: Assets.Images.Content.GemTrees.PurityGemTree_Stone.Asset,
            TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Diamond.Asset,
            Branches: Assets.Images.Content.GemTrees.PurityGemTree_Stone_Branches.Asset,
            BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Diamond_Branches.Asset,
            Tops: Assets.Images.Content.GemTrees.PurityGemTree_Stone_TreeTops.Asset,
            TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Diamond_Tops.Asset
        ),
        PuritySaplings: new GemTreeVanitySaplingDescription(
            Sapling: Assets.Images.Content.GemTrees.PurityGemTree_Stone_Saplings.Asset,
            SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
        ),
        Biomes: new Dictionary<int, GemTreeVanityDescription>
        {
            [BiomeConversionID.Corruption] = new(
                Trunk: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone.Asset,
                TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Diamond.Asset,
                Branches: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone_Branches.Asset,
                BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Diamond_Branches.Asset,
                Tops: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone_TreeTops.Asset,
                TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Diamond_Tops.Asset
            ),
            [BiomeConversionID.Crimson] = new(
                Trunk: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone.Asset,
                TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Diamond.Asset,
                Branches: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone_Branches.Asset,
                BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Diamond_Branches.Asset,
                Tops: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone_TreeTops.Asset,
                TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Diamond_Tops.Asset
            ),
            [BiomeConversionID.Hallow] = new(
                Trunk: Assets.Images.Content.GemTrees.HallowGemTree_Stone.Asset,
                TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Diamond.Asset,
                Branches: Assets.Images.Content.GemTrees.HallowGemTree_Stone_Branches.Asset,
                BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Diamond_Branches.Asset,
                Tops: Assets.Images.Content.GemTrees.HallowGemTree_Stone_TreeTops.Asset,
                TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Diamond_Tops.Asset
            ),
        },
        SaplingBiomes: new Dictionary<int, GemTreeVanitySaplingDescription>
        {
            [BiomeConversionID.Corruption] = new(
                Sapling: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone_Saplings.Asset,
                SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
            ),
            [BiomeConversionID.Crimson] = new(
                Sapling: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone_Saplings.Asset,
                SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
            ),
            [BiomeConversionID.Hallow] = new(
                Sapling: Assets.Images.Content.GemTrees.HallowGemTree_Stone_Saplings.Asset,
                SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
            ),
        }
    );

    public static readonly GemTreeVanityProfile TOPAZ = new(
        Purity: new GemTreeVanityDescription(
            Trunk: Assets.Images.Content.GemTrees.PurityGemTree_Stone.Asset,
            TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Topaz.Asset,
            Branches: Assets.Images.Content.GemTrees.PurityGemTree_Stone_Branches.Asset,
            BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Topaz_Branches.Asset,
            Tops: Assets.Images.Content.GemTrees.PurityGemTree_Stone_TreeTops.Asset,
            TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Topaz_Tops.Asset
        ),
        PuritySaplings: new GemTreeVanitySaplingDescription(
            Sapling: Assets.Images.Content.GemTrees.PurityGemTree_Stone_Saplings.Asset,
            SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
        ),
        Biomes: new Dictionary<int, GemTreeVanityDescription>
        {
            [BiomeConversionID.Corruption] = new(
                Trunk: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone.Asset,
                TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Topaz.Asset,
                Branches: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone_Branches.Asset,
                BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Topaz_Branches.Asset,
                Tops: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone_TreeTops.Asset,
                TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Topaz_Tops.Asset
            ),
            [BiomeConversionID.Crimson] = new(
                Trunk: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone.Asset,
                TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Topaz.Asset,
                Branches: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone_Branches.Asset,
                BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Topaz_Branches.Asset,
                Tops: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone_TreeTops.Asset,
                TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Topaz_Tops.Asset
            ),
            [BiomeConversionID.Hallow] = new(
                Trunk: Assets.Images.Content.GemTrees.HallowGemTree_Stone.Asset,
                TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Topaz.Asset,
                Branches: Assets.Images.Content.GemTrees.HallowGemTree_Stone_Branches.Asset,
                BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Topaz_Branches.Asset,
                Tops: Assets.Images.Content.GemTrees.HallowGemTree_Stone_TreeTops.Asset,
                TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Topaz_Tops.Asset
            ),
        },
        SaplingBiomes: new Dictionary<int, GemTreeVanitySaplingDescription>
        {
            [BiomeConversionID.Corruption] = new(
                Sapling: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone_Saplings.Asset,
                SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
            ),
            [BiomeConversionID.Crimson] = new(
                Sapling: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone_Saplings.Asset,
                SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
            ),
            [BiomeConversionID.Hallow] = new(
                Sapling: Assets.Images.Content.GemTrees.HallowGemTree_Stone_Saplings.Asset,
                SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
            ),
        }
    );

    public static readonly GemTreeVanityProfile AMETHYST = new(
        Purity: new GemTreeVanityDescription(
            Trunk: Assets.Images.Content.GemTrees.PurityGemTree_Stone.Asset,
            TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Amethyst.Asset,
            Branches: Assets.Images.Content.GemTrees.PurityGemTree_Stone_Branches.Asset,
            BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Amethyst_Branches.Asset,
            Tops: Assets.Images.Content.GemTrees.PurityGemTree_Stone_TreeTops.Asset,
            TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Amethyst_Tops.Asset
        ),
        PuritySaplings: new GemTreeVanitySaplingDescription(
            Sapling: Assets.Images.Content.GemTrees.PurityGemTree_Stone_Saplings.Asset,
            SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
        ),
        Biomes: new Dictionary<int, GemTreeVanityDescription>
        {
            [BiomeConversionID.Corruption] = new(
                Trunk: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone.Asset,
                TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Amethyst.Asset,
                Branches: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone_Branches.Asset,
                BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Amethyst_Branches.Asset,
                Tops: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone_TreeTops.Asset,
                TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Amethyst_Tops.Asset
            ),
            [BiomeConversionID.Crimson] = new(
                Trunk: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone.Asset,
                TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Amethyst.Asset,
                Branches: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone_Branches.Asset,
                BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Amethyst_Branches.Asset,
                Tops: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone_TreeTops.Asset,
                TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Amethyst_Tops.Asset
            ),
            [BiomeConversionID.Hallow] = new(
                Trunk: Assets.Images.Content.GemTrees.HallowGemTree_Stone.Asset,
                TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Amethyst.Asset,
                Branches: Assets.Images.Content.GemTrees.HallowGemTree_Stone_Branches.Asset,
                BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Amethyst_Branches.Asset,
                Tops: Assets.Images.Content.GemTrees.HallowGemTree_Stone_TreeTops.Asset,
                TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Amethyst_Tops.Asset
            ),
        },
        SaplingBiomes: new Dictionary<int, GemTreeVanitySaplingDescription>
        {
            [BiomeConversionID.Corruption] = new(
                Sapling: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone_Saplings.Asset,
                SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
            ),
            [BiomeConversionID.Crimson] = new(
                Sapling: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone_Saplings.Asset,
                SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
            ),
            [BiomeConversionID.Hallow] = new(
                Sapling: Assets.Images.Content.GemTrees.HallowGemTree_Stone_Saplings.Asset,
                SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
            ),
        }
    );

    public static readonly GemTreeVanityProfile SAPPHIRE = new(
        Purity: new GemTreeVanityDescription(
            Trunk: Assets.Images.Content.GemTrees.PurityGemTree_Stone.Asset,
            TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Sapphire.Asset,
            Branches: Assets.Images.Content.GemTrees.PurityGemTree_Stone_Branches.Asset,
            BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Sapphire_Branches.Asset,
            Tops: Assets.Images.Content.GemTrees.PurityGemTree_Stone_TreeTops.Asset,
            TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Sapphire_Tops.Asset
        ),
        PuritySaplings: new GemTreeVanitySaplingDescription(
            Sapling: Assets.Images.Content.GemTrees.PurityGemTree_Stone_Saplings.Asset,
            SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
        ),
        Biomes: new Dictionary<int, GemTreeVanityDescription>
        {
            [BiomeConversionID.Corruption] = new(
                Trunk: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone.Asset,
                TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Sapphire.Asset,
                Branches: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone_Branches.Asset,
                BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Sapphire_Branches.Asset,
                Tops: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone_TreeTops.Asset,
                TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Sapphire_Tops.Asset
            ),
            [BiomeConversionID.Crimson] = new(
                Trunk: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone.Asset,
                TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Sapphire.Asset,
                Branches: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone_Branches.Asset,
                BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Sapphire_Branches.Asset,
                Tops: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone_TreeTops.Asset,
                TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Sapphire_Tops.Asset
            ),
            [BiomeConversionID.Hallow] = new(
                Trunk: Assets.Images.Content.GemTrees.HallowGemTree_Stone.Asset,
                TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Sapphire.Asset,
                Branches: Assets.Images.Content.GemTrees.HallowGemTree_Stone_Branches.Asset,
                BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Sapphire_Branches.Asset,
                Tops: Assets.Images.Content.GemTrees.HallowGemTree_Stone_TreeTops.Asset,
                TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Sapphire_Tops.Asset
            ),
        },
        SaplingBiomes: new Dictionary<int, GemTreeVanitySaplingDescription>
        {
            [BiomeConversionID.Corruption] = new(
                Sapling: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone_Saplings.Asset,
                SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
            ),
            [BiomeConversionID.Crimson] = new(
                Sapling: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone_Saplings.Asset,
                SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
            ),
            [BiomeConversionID.Hallow] = new(
                Sapling: Assets.Images.Content.GemTrees.HallowGemTree_Stone_Saplings.Asset,
                SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
            ),
        }
    );

    public static readonly GemTreeVanityProfile EMERALD = new(
        Purity: new GemTreeVanityDescription(
            Trunk: Assets.Images.Content.GemTrees.PurityGemTree_Stone.Asset,
            TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Emerald.Asset,
            Branches: Assets.Images.Content.GemTrees.PurityGemTree_Stone_Branches.Asset,
            BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Emerald_Branches.Asset,
            Tops: Assets.Images.Content.GemTrees.PurityGemTree_Stone_TreeTops.Asset,
            TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Emerald_Tops.Asset
        ),
        PuritySaplings: new GemTreeVanitySaplingDescription(
            Sapling: Assets.Images.Content.GemTrees.PurityGemTree_Stone_Saplings.Asset,
            SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
        ),
        Biomes: new Dictionary<int, GemTreeVanityDescription>
        {
            [BiomeConversionID.Corruption] = new(
                Trunk: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone.Asset,
                TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Emerald.Asset,
                Branches: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone_Branches.Asset,
                BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Emerald_Branches.Asset,
                Tops: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone_TreeTops.Asset,
                TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Emerald_Tops.Asset
            ),
            [BiomeConversionID.Crimson] = new(
                Trunk: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone.Asset,
                TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Emerald.Asset,
                Branches: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone_Branches.Asset,
                BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Emerald_Branches.Asset,
                Tops: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone_TreeTops.Asset,
                TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Emerald_Tops.Asset
            ),
            [BiomeConversionID.Hallow] = new(
                Trunk: Assets.Images.Content.GemTrees.HallowGemTree_Stone.Asset,
                TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Emerald.Asset,
                Branches: Assets.Images.Content.GemTrees.HallowGemTree_Stone_Branches.Asset,
                BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Emerald_Branches.Asset,
                Tops: Assets.Images.Content.GemTrees.HallowGemTree_Stone_TreeTops.Asset,
                TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Emerald_Tops.Asset
            ),
        },
        SaplingBiomes: new Dictionary<int, GemTreeVanitySaplingDescription>
        {
            [BiomeConversionID.Corruption] = new(
                Sapling: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone_Saplings.Asset,
                SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
            ),
            [BiomeConversionID.Crimson] = new(
                Sapling: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone_Saplings.Asset,
                SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
            ),
            [BiomeConversionID.Hallow] = new(
                Sapling: Assets.Images.Content.GemTrees.HallowGemTree_Stone_Saplings.Asset,
                SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
            ),
        }
    );

    public static readonly GemTreeVanityProfile AMBER = new(
        Purity: new GemTreeVanityDescription(
            Trunk: Assets.Images.Content.GemTrees.PurityGemTree_Stone.Asset,
            TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Amber.Asset,
            Branches: Assets.Images.Content.GemTrees.PurityGemTree_Stone_Branches.Asset,
            BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Amber_Branches.Asset,
            Tops: Assets.Images.Content.GemTrees.PurityGemTree_Stone_TreeTops.Asset,
            TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Amber_Tops.Asset
        ),
        PuritySaplings: new GemTreeVanitySaplingDescription(
            Sapling: Assets.Images.Content.GemTrees.PurityGemTree_Stone_Saplings.Asset,
            SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
        ),
        Biomes: new Dictionary<int, GemTreeVanityDescription>
        {
            [BiomeConversionID.Corruption] = new(
                Trunk: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone.Asset,
                TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Amber.Asset,
                Branches: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone_Branches.Asset,
                BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Amber_Branches.Asset,
                Tops: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone_TreeTops.Asset,
                TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Amber_Tops.Asset
            ),
            [BiomeConversionID.Crimson] = new(
                Trunk: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone.Asset,
                TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Amber.Asset,
                Branches: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone_Branches.Asset,
                BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Amber_Branches.Asset,
                Tops: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone_TreeTops.Asset,
                TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Amber_Tops.Asset
            ),
            [BiomeConversionID.Hallow] = new(
                Trunk: Assets.Images.Content.GemTrees.HallowGemTree_Stone.Asset,
                TrunkGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Amber.Asset,
                Branches: Assets.Images.Content.GemTrees.HallowGemTree_Stone_Branches.Asset,
                BranchesGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Amber_Branches.Asset,
                Tops: Assets.Images.Content.GemTrees.HallowGemTree_Stone_TreeTops.Asset,
                TopsGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Amber_Tops.Asset
            ),
        },
        SaplingBiomes: new Dictionary<int, GemTreeVanitySaplingDescription>
        {
            [BiomeConversionID.Corruption] = new(
                Sapling: Assets.Images.Content.GemTrees.CorruptionGemTree_Stone_Saplings.Asset,
                SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
            ),
            [BiomeConversionID.Crimson] = new(
                Sapling: Assets.Images.Content.GemTrees.CrimsonGemTree_Stone_Saplings.Asset,
                SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
            ),
            [BiomeConversionID.Hallow] = new(
                Sapling: Assets.Images.Content.GemTrees.HallowGemTree_Stone_Saplings.Asset,
                SaplingGems: Assets.Images.Content.GemTrees.Engraved.PurityGemTree_Saplings.Asset
            ),
        }
    );

    public static GemTreeVanityProfile? GetProfile(int tileId)
    {
        return tileId switch
        {
            TileID.TreeRuby => RUBY,
            TileID.TreeDiamond => DIAMOND,
            TileID.TreeTopaz => TOPAZ,
            TileID.TreeAmethyst => AMETHYST,
            TileID.TreeSapphire => SAPPHIRE,
            TileID.TreeEmerald => EMERALD,
            TileID.TreeAmber => AMBER,
            _ => null,
        };
    }
}
