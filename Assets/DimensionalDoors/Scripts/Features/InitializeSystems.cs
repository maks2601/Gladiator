using DimensionalDoors.Systems.InitializeSystems;

namespace DimensionalDoors.Features
{
    public sealed class InitializeSystems : Feature
    {
        public InitializeSystems(Contexts contexts)
        {
            Add(new WaveInitializeSystem(contexts));
            Add(new SpawnersInitializeSystem(contexts));
            Add(new PhysicsInitializeSystem(contexts));
            Add(new EnemyInitializeSystem(contexts));
            Add(new PlayerInitializeSystem(contexts));
        }
    }
}