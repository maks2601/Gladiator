using System;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Components
{
    [Game, Input, Spawn, Serializable]
    public sealed class TimerComponent : IComponent
    {
        public float time;
    }
}