using System;
using DimensionalDoors.Base.Spawn;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Components.Spawn
{
    [Spawn, Serializable]
    public sealed class SpawnerComponent : IComponent
    {
        public Spawner spawner;
    }
}