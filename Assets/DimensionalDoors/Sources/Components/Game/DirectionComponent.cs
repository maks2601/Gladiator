using System;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Components.Game
{
    [Game, Serializable]
    public sealed class DirectionComponent : IComponent
    {
        public Vector2 direction;
    }
}