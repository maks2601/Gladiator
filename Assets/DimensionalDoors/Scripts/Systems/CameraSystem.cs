// using System;
// using DimensionalDoors.Scripts.Components;
// using Leopotam.Ecs;
// using UnityEngine;
//
// namespace DimensionalDoors.Scripts.Systems
// {
//     public class CameraSystem : IEcsRunSystem
//     {
//         private EcsFilter<CameraComponent> filter;
//         
//         public void Run()
//         {
//             foreach (var index in filter)
//             {
//                 ref var cameraComponent = ref filter.Get1(index);
//                 Follow(ref cameraComponent);
//             }
//         }
//         
//         private void Follow(ref CameraComponent cameraComponent)
//         {
//             var camera = cameraComponent.camera;
//             var target = cameraComponent.target;
//             var offset = cameraComponent.offset;
//             var smoothSpeed = cameraComponent.smoothSpeed;
//             var desiredPosition = target.position + offset;
//             var smoothedPosition = Vector3.Lerp(camera.transform.position, desiredPosition, smoothSpeed);
//             camera.transform.position = smoothedPosition;
//
//             camera.transform.LookAt(target);
//         }
//     }
// }