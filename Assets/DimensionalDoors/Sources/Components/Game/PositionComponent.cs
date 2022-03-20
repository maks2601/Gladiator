using System;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Components.Game
{
    [Game, Serializable]
    public class PositionComponent : IComponent
    {
        public Vector3 position;
    }
}