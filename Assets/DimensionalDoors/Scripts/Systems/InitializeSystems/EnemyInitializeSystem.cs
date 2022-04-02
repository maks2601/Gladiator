using System.Collections.Generic;
using DimensionalDoors.Base;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Systems.InitializeSystems
{
    public sealed class EnemyInitializeSystem : ReactiveSystem<GameEntity>
    {
        public EnemyInitializeSystem(Contexts contexts) : base(contexts.Game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.Spawned.Added());
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.HasScanField && entity.HasView;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var e in entities)
            {
                var reporter = e.View.gameObject.AddComponent<TriggerReporter>();
                e.ScanField.scanField.radius = e.ScanField.fieldSize;
                reporter.entity = e;
            }
        }
    }
}