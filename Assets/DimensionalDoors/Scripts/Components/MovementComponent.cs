using System;
using DimensionalDoors.Scripts.Enums;
using UnityEngine;

namespace DimensionalDoors.Scripts.Components
{
    [Serializable]
    public struct MovementComponent
    {
        public float speed;
        [HideInInspector] public Vector3 direction;
        [HideInInspector] public MoveState moveState;
    }
}