using System.Collections.Generic;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Systems.LogicSystems
{
    public sealed class AttackHandleSystem : ReactiveSystem<GameEntity>
    {
        public AttackHandleSystem(Contexts contexts) : base(contexts.Game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.Collisions.Added());
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.IsWeapon;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var e in entities)
            {
                foreach (var collision in e.Collisions.list)
                {
                    collision.IsAttacked = true;
                }
                e.RemoveCollisions();
            }
        }
    }
}