using DimensionalDoors.Systems;

namespace DimensionalDoors.Features
{
    public sealed class LogicSystems : Feature  {
        public LogicSystems(Contexts contexts)
        {
            Add(new RotateSystem(contexts));
            Add(new InputMoveSystem(contexts));
            Add(new MoveSystem(contexts));
            Add(new CollisionSystem(contexts));
        }	
    }
}