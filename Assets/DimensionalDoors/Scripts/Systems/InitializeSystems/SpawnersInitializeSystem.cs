using System.Collections.Generic;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Systems.InitializeSystems
{
    public class SpawnersInitializeSystem : ReactiveSystem<SpawnEntity>
    {
        private readonly SpawnContext _context;
        
        public SpawnersInitializeSystem(Contexts contexts) : base(contexts.Spawn)
        {
            _context = contexts.Spawn;
        }

        protected override ICollector<SpawnEntity> GetTrigger(IContext<SpawnEntity> context)
        {
            return context.CreateCollector(SpawnMatcher.Arena.Added(), SpawnMatcher.Wave.Added());
        }

        protected override bool Filter(SpawnEntity entity)
        {
            return entity.HasSpawner && entity.HasArena && entity.HasWave;
        }

        protected override void Execute(List<SpawnEntity> entities)
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