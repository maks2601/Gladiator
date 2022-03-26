using System.Collections.Generic;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Systems.InitializeSystems
{
    public class SpawnersInitializeSystem : ReactiveSystem<GameEntity>
    {
        private readonly GameContext _context;
        
        public SpawnersInitializeSystem(Contexts contexts) : base(contexts.Game)
        {
            _context = contexts.Game;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.Arena.Added(), GameMatcher.Wave.Added());
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.HasSpawner && entity.HasArena && entity.HasWave;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var e in entities)
            {
                var spawner = e.Spawner.spawner;
                var arena = spawner.arenas[e.Arena.currentArena];
                var wave = arena.waves[e.Wave.currentWave];
                foreach (var spawnable in wave.spawnables)
                {
                    var entity = _context.CreateEntity();
                    entity.CopySpawnableTo(spawnable);
                }
            }
        }
    }
}