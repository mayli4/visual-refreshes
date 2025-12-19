using Terraria.ID;

namespace Refreshes.Content;

partial class GemTreeRendering
{
    private static readonly object[] default_renderers =
    [
        TileID.TreeTopaz, new TreeRenderer(),
        TileID.TreeAmethyst, new TreeRenderer(),
        TileID.TreeSapphire, new TreeRenderer(),
        TileID.TreeEmerald, new TreeRenderer(),
        TileID.TreeRuby, new TreeRenderer(),
        TileID.TreeDiamond, new TreeRenderer(),
        TileID.TreeAmber, new TreeRenderer(),
        TileID.GemSaplings, new SaplingRenderer(),
    ];

    public static GemTreeRenderer?[] GemTreeRenderers { get; private set; } = [];

    public override void ResizeArrays()
    {
        base.ResizeArrays();

        GemTreeRenderers = TileID.Sets.Factory.CreateNamedSet((Mod)Mod, nameof(GemTreeRenderers))
                                 .Description("Renderers for gem trees")
                                 .RegisterCustomSet(default(GemTreeRenderer), default_renderers);
    }
}
