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
            _movableGroup = contexts.Game.GetGroup(GameMatcher.AllOf(GameMatcher.Controlled, GameMatcher.View));
        }

        protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
        {
            return context.CreateCollector(InputMatcher.Touch.Added());
        }

        protected override bool Filter(InputEntity entity)
        {
            return entity.IsController;
        }

        protected override void Execute(List<InputEntity> entities)
        {
            foreach (var input in entities)
            {
                foreach (var e in _movableGroup.GetEntities())
                {
                    Vector2 position = e.View.gameObject.transform.position;
                    var distance = input.Touch.endPoint - input.Touch.startPoint;
                    e.ReplaceTargetPoint(position + distance);
                    if (!input.IsTouched && e.HasMove) e.IsMoving = true;
                }
            }
        }
    }
}