using System.Collections.Generic;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Systems.InputSystems
{
    public sealed class InputMoveSystem : ReactiveSystem<InputEntity>
    {
        private readonly IGroup<GameEntity> _movableGroup;

        public InputMoveSystem(Contexts contexts) : base(contexts.Input)
        {
            _movableGroup = contexts.Game.GetGroup(GameMatcher.AllOf(GameMatcher.Controlled, GameMatcher.Movable));
        }

        protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
        {
            return context.CreateCollector(InputMatcher.Touched.Removed());
        }

        protected override bool Filter(InputEntity entity)
        {
            return entity.HasInput;
        }

        protected override void Execute(List<InputEntity> entities)
        {
            foreach (var input in entities)
            {
                foreach (var e in _movableGroup.GetEntities())
                {
                    e.IsMoving = true;
                }
            }
        }
    }
}