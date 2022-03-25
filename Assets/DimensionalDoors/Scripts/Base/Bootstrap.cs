using DimensionalDoors.Features;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Base
{
    public sealed class Bootstrap : MonoBehaviour
    {
        [SerializeField] private GameBlueprintBehaviour playerBehaviour;
        [SerializeField] private InputBlueprintBehaviour inputBehaviour;
        private JCMG.EntitasRedux.Systems _systems;
        private Contexts _contexts;

        private void Start()
        {
            _contexts = Contexts.SharedInstance;
            CreateGameEntity(playerBehaviour);
            CreateInputEntity(inputBehaviour);
            _systems = new AllSystems(_contexts);
            _systems.Initialize();
        }

        private void CreateGameEntity(GameBlueprintBehaviour behaviour)
        {
            var blueprint = Instantiate(behaviour);
            var entity = _contexts.Game.CreateEntity();
            blueprint.gameObject.Link(entity);
            blueprint.ApplyToEntity(entity);
            Destroy(blueprint);
            entity.IsSpawnable = true;
        }

        private void CreateInputEntity(InputBlueprintBehaviour inputBlueprint)
        {
            var entity = _contexts.Input.CreateEntity();
            inputBlueprint.ApplyToEntity(entity);
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