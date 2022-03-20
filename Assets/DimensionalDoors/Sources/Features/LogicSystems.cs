using DimensionalDoors.Systems;

namespace DimensionalDoors.Features
{
    public class LogicSystems : Feature  {
        public LogicSystems(Contexts contexts)
        {
            Add(new MoveSystem(contexts));
            Add(new CollisionSystem(contexts));
        }	
    }
}