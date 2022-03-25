using System.Collections.Generic;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Systems.LogicSystems
{
    public sealed class RotateSystem : ReactiveSystem<GameEntity>
    {
        public RotateSystem(Contexts contexts) : base(contexts.Game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.TargetPoint.Added());
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.IsRotatable && entity.HasView;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var e in entities)
            {
                var eTransform = e.View.gameObject.transform;
                eTransform.rotation = Quaternion.LookRotation(Vector3.forward, e.TargetPoint.targetPoint);
            }
        }
    }
}