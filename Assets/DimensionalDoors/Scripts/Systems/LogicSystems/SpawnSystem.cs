using DimensionalDoors.Extensions;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Systems.LogicSystems
{
    public class SpawnSystem : IUpdateSystem
    {
        private readonly Contexts _contexts;
        private readonly IGroup<SpawnEntity> _spawnableGroup;

        public SpawnSystem(Contexts contexts)
        {
            _contexts = contexts;
            _spawnableGroup =
                _contexts.Spawn.GetGroup(SpawnMatcher.AllOf(SpawnMatcher.Spawnable).NoneOf(SpawnMatcher.Timer));
        }

        public void Update()
        {
            foreach (var e in _spawnableGroup.GetEntities())
            {
                if (e.Spawnable.count == 0)
                {
                    e.Destroy();
                    continue;
                }

                var spawnedEntity = e.Spawnable.spawnable.CreateEntity(_contexts.Game, true);
                spawnedEntity.IsSpawned = true;
                e.Spawnable.count--;
                e.AddTimer(e.Spawnable.spawnPeriod);
            }
        }
    }
}