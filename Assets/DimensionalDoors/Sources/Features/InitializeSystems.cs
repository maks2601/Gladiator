using DimensionalDoors.Systems;

namespace DimensionalDoors.Features
{
    public class InitializeSystems : Feature
    {
        public InitializeSystems(Contexts contexts)
        {
            Add(new SpawnSystem(contexts));
            Add(new PhysicsInitializeSystem(contexts));
        }
    }
}