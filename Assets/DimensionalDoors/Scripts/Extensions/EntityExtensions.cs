using JCMG.EntitasRedux;
using UnityEngine;

namespace DimensionalDoors.Extensions
{
    public static class EntityExtensions
    {
        public static void UnlinkAndDestroy(this GameEntity entity)
        {
            entity.View.gameObject.Unlink();
            Object.Destroy(entity.View.gameObject);
            entity.Destroy();
        }
    }
}