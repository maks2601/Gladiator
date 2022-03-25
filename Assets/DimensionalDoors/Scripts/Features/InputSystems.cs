using DimensionalDoors.Systems.InputSystems;

namespace DimensionalDoors.Features
{
    public class InputSystems : Feature
    {
        public InputSystems(Contexts contexts)
        {
            Add(new ScreenInputSystem(contexts));
            Add(new WorldInputSystem(contexts));
            Add(new InputTargetPointSystem(contexts));
        }
    }
}