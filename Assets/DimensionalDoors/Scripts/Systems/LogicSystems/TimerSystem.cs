using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Systems.LogicSystems
{
    public class TimerSystem : IUpdateSystem
    {
        private readonly IGroup<GameEntity> _gameTimerGroup;
        private readonly IGroup<SpawnEntity> _spawnTimerGroup;

        public TimerSystem(Contexts contexts)
        {
            _gameTimerGroup = contexts.Game.GetGroup(GameMatcher.Timer);
            _spawnTimerGroup = contexts.Spawn.GetGroup(SpawnMatcher.Timer);
        }
        
        public void Update()
        {
            foreach (var e in _gameTimerGroup.GetEntities())
            {
                e.Timer.time -= Time.deltaTime;
                if(e.Timer.time <= 0) e.RemoveTimer();
            }
            foreach (var e in _spawnTimerGroup.GetEntities())
            {
                e.Timer.time -= Time.deltaTime;
                if(e.Timer.time <= 0) e.RemoveTimer();
            }
        }
    }
}