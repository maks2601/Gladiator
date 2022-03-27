using System;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Components.Spawn
{
    [Spawn, Serializable]
    public sealed class WaveComponent : IComponent
    {
        public int currentWave;
    }
}