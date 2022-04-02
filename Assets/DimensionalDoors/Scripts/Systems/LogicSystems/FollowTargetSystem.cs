using JCMG.EntitasRedux;

namespace DimensionalDoors.Systems.LogicSystems
{
    public sealed class FollowTargetSystem : IFixedUpdateSystem
    {
        private readonly GameContext _context;
        private readonly IGroup<GameEntity> _movableGroup;

        public FollowTargetSystem(Contexts contexts)
        {
            _context = contexts.Game;
            _movableGroup = _context.GetGroup(GameMatcher.AllOf(GameMatcher.TargetObject));
        }

        public void FixedUpdate()
        {
            foreach (var e in _movableGroup.GetEntities())
            {
                var target = e.TargetObject.target;
                if (!target.HasView) continue;
                e.ReplaceTargetPoint(target.View.gameObject.transform.position);
                if (e.HasMove) e.IsMoving = true;
            }
        }
    }
}