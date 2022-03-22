using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Components.Game
{
    [Game]
    public sealed class DirectionComponent : IComponent
    {
        public Vector2 direction;
    }
}