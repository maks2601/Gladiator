using DimensionalDoors.Extensions;
using DimensionalDoors.Features;
using UnityEngine;

namespace DimensionalDoors.Base
{
    public sealed class Bootstrap : MonoBehaviour
    {
        [SerializeField] private GameBlueprintBehaviour playerBehaviour;
        [SerializeField] private InputBlueprintBehaviour inputBehaviour;
        [SerializeField] private SpawnBlueprintBehaviour spawnerBehaviour;
        [SerializeField] private int currentArena;
        [SerializeField] private int currentWave;
        private JCMG.EntitasRedux.Systems _systems;
        private Contexts _contexts;

        private void Start()
        {
            _contexts = Contexts.SharedInstance;
            playerBehaviour.CreateEntity(_contexts.Game);
            inputBehaviour.CreateEntity(_contexts.Input);
            var spawner = spawnerBehaviour.CreateEntity(_contexts.Spawn);
            spawner.AddArena(currentArena);
            spawner.AddWave(currentWave);
            _systems = new AllSystems(_contexts);
            _systems.Initialize();
        }

        private void Update()
        {
            _systems.Execute();
            _systems.Update();
        }

        private void FixedUpdate()
        {
            _systems.FixedUpdate();
        }

        private void LateUpdate()
        {
            _systems.LateUpdate();
            _systems.Cleanup();
        }

        private void OnApplicationQuit()
        {
            _systems.TearDown();
        }
    }
}