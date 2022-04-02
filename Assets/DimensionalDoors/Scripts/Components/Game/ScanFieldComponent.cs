using System;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Components.Game
{
    [Game, Serializable]
    public sealed class ScanFieldComponent : IComponent
    {
        public CircleCollider2D scanField;
        public float fieldSize;
    }
}