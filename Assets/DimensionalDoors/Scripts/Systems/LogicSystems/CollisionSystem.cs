using System.Collections.Generic;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Systems.LogicSystems
{
    public sealed class CollisionSystem : ReactiveSystem<GameEntity>
    {
        public CollisionSystem(Contexts contexts) : base(contexts.Game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.Collisions.Added());
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.HasCollisions;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var e in entities)
            {
                foreach (var collision in e.Collisions.list)
                {
                    Debug.Log(collision.name);
                }
                e.RemoveCollisions();
            }
        }
    }
}