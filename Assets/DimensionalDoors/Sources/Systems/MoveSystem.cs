using System.Collections.Generic;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Systems
{
    public class MoveSystem : ReactiveSystem<GameEntity>
    {
        public MoveSystem(Contexts contexts) : base(contexts.Game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.Position);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.HasPosition && entity.HasView;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var e in entities)
            {
                e.View.gameObject.transform.position = e.Position.position;
            }
        }
    }
}