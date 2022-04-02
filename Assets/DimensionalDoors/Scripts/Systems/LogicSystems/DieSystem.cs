using System.Collections.Generic;
using DimensionalDoors.Extensions;
using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Systems.LogicSystems
{
    public class DieSystem : ReactiveSystem<GameEntity>
    {
        public DieSystem(Contexts contexts) : base(contexts.Game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.Attacked.Added());
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.IsAttacked && entity.HasView;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var e in entities)
            {
                if (e.HasWeaponHolder)
                {
                    var weapon = e.WeaponHolder.weapon;
                    weapon.UnlinkAndDestroy();
                }
                e.UnlinkAndDestroy();
            }
        }
    }
}