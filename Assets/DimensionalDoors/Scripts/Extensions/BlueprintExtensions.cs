using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Extensions
{
    public static class BlueprintExtensions
    {
        public static GameEntity CreateEntity(this GameBlueprintBehaviour blueprint, GameContext context,
            bool instantiate = false)
        {
            var entity = context.CreateEntity();
            if (instantiate) blueprint = Object.Instantiate(blueprint);
            blueprint.gameObject.Link(entity);
            blueprint.ApplyToEntity(entity);
            Object.Destroy(blueprint);
            return entity;
        }
        
        public static InputEntity CreateEntity(this InputBlueprintBehaviour blueprint, InputContext context,
            bool instantiate = false)
        {
            var entity = context.CreateEntity();
            if (instantiate) blueprint = Object.Instantiate(blueprint);
            blueprint.gameObject.Link(entity);
            blueprint.ApplyToEntity(entity);
            Object.Destroy(blueprint);
            return entity;
        }
        
        public static SpawnEntity CreateEntity(this SpawnBlueprintBehaviour blueprint, SpawnContext context,
            bool instantiate = false)
        {
            var entity = context.CreateEntity();
            if (instantiate) blueprint = Object.Instantiate(blueprint);
            blueprint.gameObject.Link(entity);
            blueprint.ApplyToEntity(entity);
            Object.Destroy(blueprint);
            return entity;
        }
    }
}