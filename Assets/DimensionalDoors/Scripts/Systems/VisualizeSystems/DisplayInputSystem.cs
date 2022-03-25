using System;
using System.Collections.Generic;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Systems.VisualizeSystems
{
    public sealed class DisplayInputSystem : ReactiveSystem<InputEntity>
    {
        public DisplayInputSystem(Contexts contexts) : base(contexts.Input)
        {
        }

        protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
        {
            return context.CreateCollector(InputMatcher.Touch.Added());
        }

        protected override bool Filter(InputEntity entity)
        {
            return entity.HasDisplayInput;
        }

        protected override void Execute(List<InputEntity> entities)
        {
            foreach (var e in entities)
            {
                var line = e.DisplayInput.lineRenderer;
                if (!e.IsTouched)
                {
                    line.positionCount = 0;
                    continue;
                }
                var points = new Vector3[] { e.Touch.startPoint, e.Touch.endPoint };
                line.positionCount = 2;
                line.SetPositions(points);
            }
        }
    }
}