using System.Collections.Generic;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Base
{
    public sealed class CollisionReporter : MonoBehaviour
    {
        public GameEntity entity;

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (!entity.HasCollisions) entity.AddCollisions(new List<GameEntity>());
            var otherEntityLink = other.gameObject.GetEntityLink();
            if (otherEntityLink == null) return;
            var otherEntity = otherEntityLink.Entity;
            if (otherEntity is not GameEntity gameEntity) return;
            entity.Collisions.list.Add(gameEntity);
        }
    }
}