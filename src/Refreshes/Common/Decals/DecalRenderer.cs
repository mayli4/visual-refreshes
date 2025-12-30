using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refreshes.Common.Decals;

public abstract class DecalRenderer : ModType
{
    protected sealed override void Register()
    {
        ModTypeLookup<DecalRenderer>.Register(this);
    }
    public abstract ushort Type { get; }

    public abstract void Draw(DecalData data, SpriteBatch spriteBatch);

}