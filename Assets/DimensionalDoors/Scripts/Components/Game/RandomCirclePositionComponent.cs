using System;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Components.Game
{
    [Game, Serializable]
    public sealed class RandomCirclePositionComponent : IComponent
    {
        public float radius;
    }
}