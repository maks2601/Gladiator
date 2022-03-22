using DimensionalDoors.Systems.LogicSystems;

namespace DimensionalDoors.Features
{
    public sealed class LogicSystems : Feature  {
        public LogicSystems(Contexts contexts)
        {
            Add(new RotateSystem(contexts));
            Add(new TargetMoveSystem(contexts));
            Add(new CollisionSystem(contexts));
        }	
    }
}