using System.Collections.Generic;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Systems.LogicSystems
{
    public class RandomPositionSystem : ReactiveSystem<GameEntity>
    {
        public RandomPositionSystem(Contexts contexts) : base(contexts.Game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.Spawned.Added());
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.HasRandomCirclePosition && entity.HasView;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var e in entities)
            {
                var eTransform = e.View.gameObject.transform;
                eTransform.position = UnityEngine.Random.insideUnitCircle * e.RandomCirclePosition.radius;
            }
        }
    }
}