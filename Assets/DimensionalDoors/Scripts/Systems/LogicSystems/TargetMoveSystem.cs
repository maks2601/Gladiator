using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Systems.LogicSystems
{
    public sealed class TargetMoveSystem : IFixedUpdateSystem
    {
        private readonly GameContext _context;
        private readonly IGroup<GameEntity> _movableGroup;

        public TargetMoveSystem(Contexts contexts)
        {
            _context = contexts.Game;
            _movableGroup = _context.GetGroup(GameMatcher.AllOf(GameMatcher.TargetPoint, GameMatcher.Moving,
                GameMatcher.View, GameMatcher.Physics));
        }

        public void FixedUpdate()
        {
            foreach (var e in _movableGroup.GetEntities())
            {
                Vector2 position = e.View.gameObject.transform.position;
                var rigidbody = e.Physics.rigidbody;
                var target = e.TargetPoint.targetPoint;
                var direction = (target - position).normalized;
                rigidbody.velocity = direction * e.Move.speed;
                var errorDistance = e.Move.speed * Time.fixedDeltaTime;
                if (!(Vector2.Distance(position, target) <= errorDistance)) continue;
                rigidbody.velocity = Vector2.zero;
                e.IsMoving = false;
            }
        }
    }
}