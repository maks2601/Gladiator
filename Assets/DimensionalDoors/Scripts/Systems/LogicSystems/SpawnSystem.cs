using DimensionalDoors.Extensions;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Systems.LogicSystems
{
    public class SpawnSystem : IUpdateSystem
    {
        private readonly GameContext _context;
        private readonly IGroup<GameEntity> _spawnableGroup;

        public SpawnSystem(Contexts contexts)
        {
            _context = contexts.Game;
            _spawnableGroup = _context.GetGroup(GameMatcher.AllOf(GameMatcher.Spawnable).NoneOf(GameMatcher.Timer));
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

                var spawnedEntity = e.Spawnable.spawnable.CreateEntity(_context, true);
                spawnedEntity.IsSpawned = true;
                e.Spawnable.count--;
                e.AddTimer(e.Spawnable.spawnPeriod);
            }
        }
    }
}