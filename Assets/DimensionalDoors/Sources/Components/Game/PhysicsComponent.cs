using System;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Components.Game
{
    [Game, Serializable]
    public class PhysicsComponent : IComponent
    {
        public Rigidbody2D rigidbody;
    }
}