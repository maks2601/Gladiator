using System.Collections.Generic;
using DimensionalDoors.Extensions;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Systems.InitializeSystems
{
    public class PlayerInitializeSystem : ReactiveSystem<GameEntity>
    {
        private readonly Contexts _contexts;
        
        public PlayerInitializeSystem(Contexts contexts) : base(contexts.Game)
        {
            _contexts = contexts;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.Spawned.Added());
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.IsPlayer && entity.HasView;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var e in entities)
            {
                WeaponExtensions.TryInitializeWeapon(e, _contexts);
            }
        }
    }
}