using DimensionalDoors.Extensions;
using DimensionalDoors.Features;
using UnityEngine;

namespace DimensionalDoors.Base
{
    public sealed class Bootstrap : MonoBehaviour
    {
        [SerializeField] private SpawnBlueprintBehaviour gameConfig;
        private JCMG.EntitasRedux.Systems _systems;
        private Contexts _contexts;

        private void Start()
        {
            _contexts = Contexts.SharedInstance;
            gameConfig.CreateEntity(_contexts.Spawn);
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