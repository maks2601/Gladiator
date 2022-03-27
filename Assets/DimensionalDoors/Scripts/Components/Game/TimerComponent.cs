using System;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Components.Game
{
    [Game, Input, Spawn, Serializable]
    public sealed class TimerComponent : IComponent
    {
        public float time;
    }
}