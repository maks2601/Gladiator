// using DimensionalDoors.Scripts.Components;
// using DimensionalDoors.Scripts.Extensions;
// using Leopotam.Ecs;
// using UnityEngine;
//
// namespace DimensionalDoors.Scripts.Systems
// {
//     public class InputSystem : IEcsRunSystem
//     {
//         private EcsFilter<InputComponent> filter;
//
//         public void Run()
//         {
//             foreach (var index in filter)
//             {
//                 ref var input = ref filter.Get1(index);
//                 GetTouch(ref input);
//             }
//         }
//
//         private void GetTouch(ref InputComponent input)
//         {
//             if (Input.touchCount == 0)
//             {
//                 input.firstTouchPhase = TouchPhase.Canceled;
//                 return;
//             }
//
//             var touch = Input.GetTouch(0);
//             input.firstTouchPhase = touch.phase;
//
//             if (touch.phase == TouchPhase.Began)
//             {
//                 input.startPoint =
//                     input.currentCamera.ConvertPointToCameraSpace(touch
//                         .position, input.cameraPointSpace);
//                 return;
//             }
//
//             input.endPoint = input.currentCamera.ConvertPointToCameraSpace(touch
//                 .position, input.cameraPointSpace);
//         }
//     }
// }