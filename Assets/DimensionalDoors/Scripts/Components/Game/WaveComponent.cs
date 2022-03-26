using System;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Components.Game
{
    [Game, Serializable]
    public sealed class WaveComponent : IComponent
    {
        public int currentWave;
    }
}