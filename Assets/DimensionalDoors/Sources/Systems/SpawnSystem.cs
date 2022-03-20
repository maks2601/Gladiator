using JCMG.EntitasRedux;

namespace DimensionalDoors.Systems
{
    public class SpawnSystem : ICleanupSystem
    {
        private GameContext _context;
        private IGroup<GameEntity> _gameGroup;

        public SpawnSystem(Contexts contexts)
        {
            _context = contexts.Game;
            _gameGroup = _context.GetGroup(GameMatcher.Spawn);
        }

        public void Cleanup()
        {
            foreach (var e in _gameGroup.GetEntities())
            {
                e.IsSpawn = false;
            }
        }
    }
}