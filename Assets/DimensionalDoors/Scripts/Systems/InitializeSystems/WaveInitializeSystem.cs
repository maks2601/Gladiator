using DimensionalDoors.Extensions;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Systems.InitializeSystems
{
    public sealed class WaveInitializeSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;
        private readonly IGroup<SpawnEntity> _gameConfigsGroup;

        public WaveInitializeSystem(Contexts contexts)
        {
            _contexts = contexts;
            _gameConfigsGroup = contexts.Spawn.GetGroup(SpawnMatcher.GameConfig);
        }
        
        public void Initialize()
        {
            foreach (var e in _gameConfigsGroup.GetEntities())
            {
                var config = e.GameConfig;
                config.inputBehaviour.CreateEntity(_contexts.Input);
                var player = config.playerBehaviour.CreateEntity(_contexts.Game);
                player.IsSpawned = true;
                var spawner = config.spawnerBehaviour.CreateEntity(_contexts.Spawn);
                spawner.AddArena(config.currentArena);
                spawner.AddWave(config.currentWave);
            }
        }
    }
}