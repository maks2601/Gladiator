using DimensionalDoors.Extensions;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Systems.InputSystems
{
    public sealed class ScreenInputSystem : IUpdateSystem
    {
        private readonly InputContext _context;
        private readonly IGroup<InputEntity> _inputGroup;

        public ScreenInputSystem(Contexts contexts)
        {
            _context = contexts.Input;
            _inputGroup = _context.GetGroup(InputMatcher.AllOf(InputMatcher.Touch).NoneOf(InputMatcher.ScreenToWorldPoint));
        }

        public void Update()
        {
            if (Input.touchCount == 0) return;

            var touch = Input.GetTouch(0);

            foreach (var e in _inputGroup)
            {
                var position = touch.position;
                touch.HandleTouch(e, position);
            }
        }
    }
}