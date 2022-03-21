using System.Collections.Generic;
using DimensionalDoors.Base;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Systems
{
    public sealed class PhysicsInitializeSystem : ReactiveSystem<GameEntity>
    {
        public PhysicsInitializeSystem(Contexts contexts) : base(contexts.Game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.Spawnable.Removed());
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.HasPhysics && entity.HasView;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var e in entities)
            {
                var reporter = e.View.gameObject.AddComponent<CollisionReporter>();
                reporter.entity = e;
            }
        }
    }
}