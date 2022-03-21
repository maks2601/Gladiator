using DimensionalDoors.Systems;

namespace DimensionalDoors.Features
{
    public class InputSystems : Feature
    {
        public InputSystems(Contexts contexts)
        {
            Add(new InputSystem(contexts));
            Add(new InputDirectionSystem(contexts));
        }
    }
}