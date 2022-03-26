using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Systems.LogicSystems
{
    public class TimerSystem : IUpdateSystem
    {
        private readonly GameContext _context;
        private readonly IGroup<GameEntity> _timerGroup;

        public TimerSystem(Contexts contexts)
        {
            _context = contexts.Game;
            _timerGroup = _context.GetGroup(GameMatcher.Timer);
        }
        
        public void Update()
        {
            foreach (var e in _timerGroup.GetEntities())
            {
                e.Timer.time -= Time.deltaTime;
                if(e.Timer.time <= 0) e.RemoveTimer();
            }
        }
    }
}