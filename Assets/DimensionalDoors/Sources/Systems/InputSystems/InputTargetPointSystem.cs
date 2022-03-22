using System.Collections.Generic;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Systems.InputSystems
{
    public sealed class InputTargetPointSystem : ReactiveSystem<InputEntity>
    {
        private readonly IGroup<GameEntity> _movableGroup;

        public InputTargetPointSystem(Contexts contexts) : base(contexts.Input)
        {
            _movableGroup =
                contexts.Game.GetGroup(GameMatcher.AllOf(GameMatcher.Movable, GameMatcher.Controlled,
                    GameMatcher.View));
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
                    var startPoint = Camera.main.ScreenToWorldPoint(input.Input.startPoint);
                    var endPoint = Camera.main.ScreenToWorldPoint(input.Input.endPoint);
                    var position = e.View.gameObject.transform.position;
                    var distance = endPoint - startPoint;
                    e.ReplaceTargetPoint(position + distance);
                }
            }
        }
    }
}