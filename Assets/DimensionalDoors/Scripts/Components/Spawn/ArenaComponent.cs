using System;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Components.Spawn
{
    [Spawn, Serializable]
    public sealed class ArenaComponent : IComponent
    {
        public int currentArena;
    }
}