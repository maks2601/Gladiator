using System.Collections.Generic;
using JCMG.EntitasRedux;

namespace DimensionalDoors.Systems.LogicSystems
{
    public sealed class UpdateScanFieldSystem : ReactiveSystem<GameEntity>
    {
        public UpdateScanFieldSystem(Contexts contexts) : base(contexts.Game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.ScanField.Added());
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.HasScanField;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var e in entities)
            {
                e.ScanField.scanField.radius = e.ScanField.fieldSize;
            }
        }
    }
}