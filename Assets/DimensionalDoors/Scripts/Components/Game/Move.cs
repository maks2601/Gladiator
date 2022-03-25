using System;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Components.Game
{
    [Game, Serializable]
    public sealed class Move : IComponent
    {
        public float speed;
    }
}