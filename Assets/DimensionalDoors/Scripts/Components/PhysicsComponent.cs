using System;
using UnityEngine;

namespace DimensionalDoors.Scripts.Components
{
    [Serializable]
    public struct PhysicsComponent
    {
        public Rigidbody2D rigidbody;
        public Collider2D collider;
    }
}