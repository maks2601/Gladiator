using System.Collections.Generic;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Systems
{
    public sealed class MoveSystem : ReactiveSystem<GameEntity>
    {
        public MoveSystem(Contexts contexts) : base(contexts.Game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.Moving);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.HasPhysics && entity.HasDirection && entity.HasView;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var e in entities)
            {
                var rigidbody= e.Physics.rigidbody;
                var direction = e.Direction.direction;
                Vector2 position = e.View.gameObject.transform.position;
                rigidbody.MovePosition(position + direction.normalized);
                e.IsMoving = false;
            }
        }
    }
}