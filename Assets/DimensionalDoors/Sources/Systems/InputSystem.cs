using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Systems
{
    public sealed class InputSystem : IUpdateSystem
    {
        private readonly InputContext _context;
        private readonly IGroup<InputEntity> _inputGroup;

        public InputSystem(Contexts contexts)
        {
            _context = contexts.Input;
            _inputGroup = _context.GetGroup(InputMatcher.Input);
        }

        public void Update()
        {
            if (Input.touchCount == 0) return;

            var touch = Input.GetTouch(0);
            
            foreach (var e in _inputGroup)
            {
                HandleTouch(e, touch);
            }
        }

        private void HandleTouch(InputEntity entity, Touch touch)
        {
            var input = entity.Input;
            if (touch.phase == TouchPhase.Began)
            {
                entity.ReplaceInput(touch.position, input.endPoint);
                entity.IsTouched = true;
                return;
            }

            entity.ReplaceInput(input.startPoint, touch.position);

            if (touch.phase == TouchPhase.Ended) entity.IsTouched = false;
        }
    }
}