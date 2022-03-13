// using System;
// using DimensionalDoors.Scripts.Components;
// using Leopotam.Ecs;
// using UnityEngine;
//
// namespace DimensionalDoors.Scripts.Systems
// {
//     public class InputDisplaySystem : IEcsRunSystem
//     {
//         private EcsFilter<InputComponent, InputDisplayComponent> filter;
//
//         public void Run()
//         {
//             foreach (var index in filter)
//             {
//                 ref var input = ref filter.Get1(index);
//                 ref var display = ref filter.Get2(index);
//
//                 var line = display.line;
//                 if (input.firstTouchPhase is TouchPhase.Moved or TouchPhase.Stationary)
//                 {
//                     DrawLine(line, input.startPoint, input.endPoint);
//                     return;
//                 }
//
//                 line.positionCount = 0;
//             }
//         }
//
//         private void DrawLine(LineRenderer line, Vector3 start, Vector3 end)
//         {
//             line.positionCount = 2;
//             var linePositions = new[] { start, end };
//             line.SetPositions(linePositions);
//         }
//     }
// }