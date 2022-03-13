// using System;
// using DimensionalDoors.Scripts.Systems;
// using Leopotam.Ecs;
// using UnityEngine;
// using Voody.UniLeo;
//
// namespace DimensionalDoors.Scripts.Base
// {
//     public class EcsInstaller : MonoBehaviour
//     {
//         private EcsWorld world;
//         private EcsSystems update;
//         private EcsSystems fixedUpdate;
//         private EcsSystems lateUpdate;
//
//         private void Start()
//         {
//             world = new EcsWorld();
//             update = new EcsSystems(world);
//             fixedUpdate = new EcsSystems(world);
//             lateUpdate = new EcsSystems(world);
//             
//             AddInjections();
//             AddOneFrames();
//             AddSystems();
//             
//             update.ConvertScene();
//             update.Init();
//             fixedUpdate.ConvertScene();
//             fixedUpdate.Init();
//             lateUpdate.ConvertScene();
//             lateUpdate.Init();
//         }
//
//         private void AddOneFrames()
//         {
//             
//         }
//
//         private void AddSystems()
//         {
//             update
//                 .Add(new InputSystem())
//                 .Add(new InputDisplaySystem())
//                 .Add(new PlayerSystem())
//                 .Add(new MovementSystem());
//             lateUpdate.Add(new CameraSystem());
//         }
//
//         private void AddInjections()
//         {
//             
//         }
//
//         private void Update()
//         {
//             update?.Run();
//         }
//
//         private void FixedUpdate()
//         {
//             fixedUpdate?.Run();
//         }
//
//         private void LateUpdate()
//         {
//             lateUpdate?.Run();
//         }
//
//         private void OnDestroy()
//         {
//             update?.Destroy();
//             fixedUpdate?.Destroy();
//             lateUpdate?.Destroy();
//             world.Destroy();
//         }
//     }
// }