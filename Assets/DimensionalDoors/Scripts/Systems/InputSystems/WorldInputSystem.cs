using DimensionalDoors.Extensions;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Systems.InputSystems
{
    public sealed class WorldInputSystem : IUpdateSystem
    {
        private readonly InputContext _context;
        private readonly IGroup<InputEntity> _inputGroup;

        public WorldInputSystem(Contexts contexts)
        {
            _context = contexts.Input;
            _inputGroup = _context.GetGroup(InputMatcher.AllOf(InputMatcher.Touch,
                InputMatcher.ScreenToWorldPoint, InputMatcher.Camera));
        }

        public void Update()
        {
            if (Input.touchCount == 0) return;

            var touch = Input.GetTouch(0);

            foreach (var e in _inputGroup)
            {
                var camera = e.Camera.camera;
                var position = camera.ScreenToWorldPoint(touch.position);
                touch.HandleTouch(e, position);
            }
        }
    }
}