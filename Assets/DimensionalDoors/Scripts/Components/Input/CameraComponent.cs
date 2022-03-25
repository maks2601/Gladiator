using System;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Components.Input
{
    [Input, Serializable]
    public sealed class CameraComponent : IComponent
    {
        public Camera camera;
    }
}