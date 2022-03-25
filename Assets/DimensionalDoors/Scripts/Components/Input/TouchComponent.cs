using System;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Components.Input
{
    [Input, Serializable]
    public sealed class TouchComponent : IComponent
    {
        public Vector2 startPoint;
        public Vector2 endPoint;
    }
}