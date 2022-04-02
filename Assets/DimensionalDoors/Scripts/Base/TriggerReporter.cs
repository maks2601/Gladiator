using System.Collections.Generic;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Base
{
    public sealed class TriggerReporter : MonoBehaviour
    {
        public GameEntity entity;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!entity.HasTriggers) entity.AddTriggers(new List<GameEntity>());
            var otherEntityLink = other.gameObject.GetEntityLink();
            if (otherEntityLink == null) return;
            var otherEntity = otherEntityLink.Entity;
            if (otherEntity is not GameEntity gameEntity) return;
            entity.Triggers.list.Add(gameEntity);
        }
    }
}