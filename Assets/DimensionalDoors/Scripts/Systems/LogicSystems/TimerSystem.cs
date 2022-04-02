using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Systems.LogicSystems
{
    public sealed class TimerSystem : IUpdateSystem
    {
        private readonly IGroup<GameEntity> _gameTimerGroup;
        private readonly IGroup<InputEntity> _inputTimerGroup;
        private readonly IGroup<SpawnEntity> _spawnTimerGroup;

        public TimerSystem(Contexts contexts)
        {
            _gameTimerGroup = contexts.Game.GetGroup(GameMatcher.Timer);
            _inputTimerGroup = contexts.Input.GetGroup(InputMatcher.Timer);
            _spawnTimerGroup = contexts.Spawn.GetGroup(SpawnMatcher.Timer);
        }
        
        public void Update()
        {
            foreach (var e in _gameTimerGroup.GetEntities()) DecreaseTime(e);
            foreach (var e in _inputTimerGroup.GetEntities()) DecreaseTime(e);
            foreach (var e in _spawnTimerGroup.GetEntities()) DecreaseTime(e);
        }

        private void DecreaseTime(ITimerEntity e)
        {
            e.Timer.time -= Time.deltaTime;
            if(e.Timer.time <= 0) e.RemoveTimer();
        }
    }
}