using System.Collections.Generic;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Systems.LogicSystems
{
    public sealed class TargetMoveSystem : ReactiveSystem<GameEntity>
    {
        private const float ErrorDistance = 0.1f;

        public TargetMoveSystem(Contexts contexts) : base(contexts.Game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.TargetPoint.Added());
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.HasView && entity.IsMoving && entity.HasPhysics;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var e in entities)
            {
                Vector2 position = e.View.gameObject.transform.position;
                var rigidbody = e.Physics.rigidbody;
                var target = e.TargetPoint.targetPoint;
                var direction = (target - position).normalized;
                rigidbody.velocity = direction;
                e.ReplaceTargetPoint(target);
                if (!(Vector2.Distance(position, target) <= ErrorDistance)) continue;
                rigidbody.velocity = Vector2.zero;
                e.IsMoving = false;
            }
        }
    }
}