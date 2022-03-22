using System;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Components.Game
{
    [Game, Serializable]
    public sealed class PhysicsComponent : IComponent
    {
        public Rigidbody2D rigidbody;
    }
}