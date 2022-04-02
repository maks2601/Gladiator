﻿using System.Collections.Generic;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Systems.LogicSystems
{
    public sealed class ScanSystem : ReactiveSystem<GameEntity>
    {
        public ScanSystem(Contexts contexts) : base(contexts.Game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.Triggers.Added());
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.HasScanField;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var e in entities)
            {
                foreach (var trigger in e.Triggers.list)
                {
                    if(trigger.IsPlayer) e.ReplaceTargetObject(trigger);
                }
                e.RemoveTriggers();
            }
        }
    }
}