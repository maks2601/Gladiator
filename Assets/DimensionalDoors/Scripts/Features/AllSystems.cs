namespace DimensionalDoors.Features
{
    public sealed class AllSystems : Feature
    {
        public AllSystems(Contexts contexts)
        {
            Add(new InputSystems(contexts));
            Add(new InitializeSystems(contexts));
            Add(new LogicSystems(contexts));
            Add(new VisualizeSystems(contexts));
        }
    }
}