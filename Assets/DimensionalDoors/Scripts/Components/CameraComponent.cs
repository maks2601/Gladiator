using System;
using UnityEngine;

namespace DimensionalDoors.Scripts.Components
{
    [Serializable]
    public struct CameraComponent
    {
        public Camera camera;
        public Transform target;
        public float smoothSpeed;
        public Vector3 offset;
    }
}