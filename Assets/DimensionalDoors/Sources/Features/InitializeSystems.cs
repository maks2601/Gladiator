using DimensionalDoors.Systems.InitializeSystems;

namespace DimensionalDoors.Features
{
    public sealed class InitializeSystems : Feature
    {
        public InitializeSystems(Contexts contexts)
        {
            Add(new SpawnSystem(contexts));
            Add(new PhysicsInitializeSystem(contexts));
        }
    }
}