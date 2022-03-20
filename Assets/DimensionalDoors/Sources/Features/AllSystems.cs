namespace DimensionalDoors.Features
{
    public class AllSystems : Feature
    {
        public AllSystems(Contexts contexts)
        {
            Add(new InitializeSystems(contexts));
            Add(new LogicSystems(contexts));
        }
    }
}