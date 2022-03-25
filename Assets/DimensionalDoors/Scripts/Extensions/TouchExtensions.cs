using UnityEngine;

namespace DimensionalDoors.Extensions
{
    public static class TouchExtensions
    {
        public static void HandleTouch(this Touch touch, InputEntity entity, Vector2 position)
        {
            var input = entity.Touch;
            if (touch.phase == TouchPhase.Began)
            {
                entity.ReplaceTouch(position, input.endPoint);
                entity.IsTouched = true;
                return;
            }

            entity.ReplaceTouch(input.startPoint, position);

            if (touch.phase == TouchPhase.Ended) entity.IsTouched = false;
        }
    }
}