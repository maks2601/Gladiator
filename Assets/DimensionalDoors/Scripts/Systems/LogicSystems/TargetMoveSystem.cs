using System.Collections.Generic;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Systems.LogicSystems
{
    public sealed class TargetMoveSystem : ReactiveSystem<GameEntity>
    {
        public TargetMoveSystem(Contexts contexts) : base(contexts.Game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.TargetPoint.Added());
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.IsMoving && entity.HasPhysics;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var e in entities)
            {
                var rigidbody= e.Physics.rigidbody;
                var target = e.TargetPoint.targetPoint;
                rigidbody.MovePosition(target);
                e.IsMoving = false;
            }
        }
    }
}