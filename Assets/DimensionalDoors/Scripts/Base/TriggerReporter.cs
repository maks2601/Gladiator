using System.Collections.Generic;
using UnityEngine;

namespace DimensionalDoors.Base
{
    public sealed class TriggerReporter : MonoBehaviour
    {
        public GameEntity entity;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!entity.HasTriggers) entity.AddTriggers(new List<GameObject>());
            entity.Triggers.list.Add(other.gameObject);
        }
    }
}