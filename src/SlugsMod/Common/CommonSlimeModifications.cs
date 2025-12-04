using Daybreak.Common.Features.Hooks;
using JetBrains.Annotations;
using Terraria.GameContent;
using Terraria.ID;

namespace SlugsMod.Common;

[UsedImplicitly]
internal sealed class CommonSlimeModifications : GlobalNPC {
    public override bool AppliesToEntity(NPC entity, bool lateInstantiation) {
        return entity.type 
            is NPCID.BlueSlime 
            or NPCID.IceSlime 
            or NPCID.UmbrellaSlime;
    }
    
    [OnLoad, UsedImplicitly]
    static void ReplaceTextures() {
        TextureAssets.Npc[NPCID.BlueSlime] = Assets.Textures.NPCs.CommonSlime.Asset;
        TextureAssets.Npc[NPCID.IceSlime] = Assets.Textures.NPCs.IceSlime.Asset;
        TextureAssets.Npc[NPCID.UmbrellaSlime] = Assets.Textures.NPCs.UmbrellaSlime.Asset;
    }
    
    [GlobalNPCHooks.PostAI, UsedImplicitly]
    static void FaceDirection(NPC npc) {
        if (npc.velocity.X != 0) {
            npc.spriteDirection = (npc.velocity.X > 0 ? 1 : -1);
        }
        
        npc.rotation = npc.velocity.X * 0.05f * npc.velocity.Y * -0.5f;
        npc.rotation = MathHelper
            .Clamp(npc.rotation, -0.25f, 0.52f);
    }
}