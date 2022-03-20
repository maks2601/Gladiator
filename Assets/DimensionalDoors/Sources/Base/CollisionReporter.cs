using System.Collections.Generic;
using UnityEngine;

namespace DimensionalDoors.Base
{
    public class CollisionReporter : MonoBehaviour
    {
        public GameEntity entity;

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (!entity.HasCollisions) entity.AddCollisions(new List<GameObject>());
            entity.Collisions.list.Add(other.gameObject);
        }
    }
}