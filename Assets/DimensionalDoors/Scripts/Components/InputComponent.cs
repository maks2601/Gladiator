using System;
using DimensionalDoors.Scripts.Enums;
using UnityEngine;

namespace DimensionalDoors.Scripts.Components
{
    [Serializable]
    public struct InputComponent
    {
        public Camera currentCamera;
        public PointSpace cameraPointSpace;
        [HideInInspector] public TouchPhase firstTouchPhase;
        [HideInInspector] public Vector2 startPoint;
        [HideInInspector] public Vector2 endPoint;
    }
}