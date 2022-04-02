using DimensionalDoors.Systems.LogicSystems;

namespace DimensionalDoors.Features
{
    public sealed class LogicSystems : Feature  {
        public LogicSystems(Contexts contexts)
        {
            Add(new SpawnSystem(contexts));
            Add(new RandomPositionSystem(contexts));
            Add(new RotateSystem(contexts));
            Add(new FollowTargetSystem(contexts));
            Add(new TargetMoveSystem(contexts));
            Add(new AttackHandleSystem(contexts));
            Add(new ScanSystem(contexts));
            Add(new UpdateScanFieldSystem(contexts));
            Add(new DieSystem(contexts));
            Add(new TimerSystem(contexts));
        }	
    }
}