using JCMG.EntitasRedux;

namespace DimensionalDoors.Systems.InitializeSystems
{
    public sealed class SpawnSystem : ICleanupSystem
    {
        private readonly GameContext _context;
        private readonly IGroup<GameEntity> _spawnGroup;

        public SpawnSystem(Contexts contexts)
        {
            _context = contexts.Game;
            _spawnGroup = _context.GetGroup(GameMatcher.Spawnable);
        }

        public void Cleanup()
        {
            foreach (var e in _spawnGroup.GetEntities())
            {
                e.IsSpawnable = false;
            }
        }
    }
}