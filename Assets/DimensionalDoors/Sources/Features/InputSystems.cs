using DimensionalDoors.Systems.InputSystems;

namespace DimensionalDoors.Features
{
    public class InputSystems : Feature
    {
        public InputSystems(Contexts contexts)
        {
            Add(new InputSystem(contexts));
            Add(new InputDirectionSystem(contexts));
            Add(new InputTargetPointSystem(contexts));
        }
    }
}