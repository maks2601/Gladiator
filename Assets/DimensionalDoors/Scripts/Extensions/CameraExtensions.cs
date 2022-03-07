using System;
using DimensionalDoors.Scripts.Enums;
using UnityEngine;

namespace DimensionalDoors.Scripts.Extensions
{
    public static class CameraExtensions
    {
        public static Vector2 ConvertPointToCameraSpace(this Camera camera, Vector2 point, PointSpace pointSpace)
        {
            switch (pointSpace)
            {
                case PointSpace.ScreenPoint:
                    return point;
                case PointSpace.WorldPoint:
                    return camera.ScreenToWorldPoint(point);
                case PointSpace.ViewportPoint:
                    return camera.ScreenToViewportPoint(point);
                default:
                    throw new ArgumentOutOfRangeException(nameof(pointSpace), pointSpace, null);
            }
        }
    }
}