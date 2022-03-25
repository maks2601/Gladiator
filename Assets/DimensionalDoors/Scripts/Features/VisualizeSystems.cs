using DimensionalDoors.Systems.VisualizeSystems;

namespace DimensionalDoors.Features
{
    public sealed class VisualizeSystems : Feature
    {
        public VisualizeSystems(Contexts contexts)
        {
            Add(new DisplayInputSystem(contexts));
        }	
    }
}