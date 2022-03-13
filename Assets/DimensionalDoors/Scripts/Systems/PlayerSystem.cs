// using System;
// using DimensionalDoors.Scripts.Components;
// using DimensionalDoors.Scripts.Enums;
// using DimensionalDoors.Scripts.Tags;
// using Leopotam.Ecs;
// using UnityEngine;
//
// namespace DimensionalDoors.Scripts.Systems
// {
//     public class PlayerSystem : IEcsRunSystem
//     {
//         private EcsFilter<PlayerTag, InputComponent, MovementComponent> filter;
//
//         public void Run()
//         {
//             foreach (var index in filter)
//             {
//                 ref var input = ref filter.Get2(index);
//                 ref var movement = ref filter.Get3(index);
//                 movement.moveState = GetMoveState(input.firstTouchPhase);
//                 movement.direction = GetDirection(input);
//             }
//         }
//
//         private MoveState GetMoveState(TouchPhase touchPhase)
//         {
//             switch (touchPhase)
//             {
//                 case TouchPhase.Began:
//                     return MoveState.Rotate;
//                 case TouchPhase.Moved:
//                     return MoveState.Rotate;
//                 case TouchPhase.Stationary:
//                     return MoveState.Stay;
//                 case TouchPhase.Ended:
//                     return MoveState.Move;
//                 case TouchPhase.Canceled:
//                     return MoveState.Stay;
//                 default:
//                     return MoveState.Stay;
//             }
//         }
//
//         private Vector3 GetDirection(InputComponent input)
//         {
//             return input.endPoint - input.startPoint;
//         }
//     }
// }