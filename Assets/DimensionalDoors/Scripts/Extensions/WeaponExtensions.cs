namespace DimensionalDoors.Extensions
{
    public static class WeaponExtensions
    {
        public static void TryInitializeWeapon(GameEntity entity, Contexts context)
        {
            if (!entity.HasWeaponInitialize) return;
            var weapon = entity.WeaponInitialize.weapon.CreateEntity(context.Game);
            weapon.IsSpawned = true;
            entity.RemoveWeaponInitialize();
            entity.AddWeaponHolder(weapon);
        }
    }
}