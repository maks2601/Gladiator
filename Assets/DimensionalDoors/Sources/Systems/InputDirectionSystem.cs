using System.Collections.Generic;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Systems
{
    public sealed class InputDirectionSystem : ReactiveSystem<InputEntity>
    {
        private readonly IGroup<GameEntity> _directionGroup;

        public InputDirectionSystem(Contexts contexts) : base(contexts.Input)
        {
            _directionGroup = contexts.Game.GetGroup(GameMatcher.AllOf(GameMatcher.Direction, GameMatcher.Controlled));
        }

        protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
        {
            return context.CreateCollector(InputMatcher.Input);
        }

        protected override bool Filter(InputEntity entity)
        {
            return entity.HasInput;
        }

        protected override void Execute(List<InputEntity> inputs)
        {
            foreach (var input in inputs)
            {
                foreach (var e in _directionGroup)
                {
                    var direction = input.Input.endPoint - input.Input.startPoint;
                    e.ReplaceDirection(direction);
                }
            }
        }
    }
}