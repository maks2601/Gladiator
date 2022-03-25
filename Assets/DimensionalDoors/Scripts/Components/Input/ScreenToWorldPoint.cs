using System;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Components.Input
{
    [Input, Serializable]
    public sealed class ScreenToWorldPoint : IComponent
    {
        public Camera camera;
    }
}