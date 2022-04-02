//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.4.4.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity
{
	public DimensionalDoors.Components.Game.WeaponInitializeComponent WeaponInitialize { get { return (DimensionalDoors.Components.Game.WeaponInitializeComponent)GetComponent(GameComponentsLookup.WeaponInitialize); } }
	public bool HasWeaponInitialize { get { return HasComponent(GameComponentsLookup.WeaponInitialize); } }

	public void AddWeaponInitialize(GameBlueprintBehaviour newWeapon)
	{
		var index = GameComponentsLookup.WeaponInitialize;
		var component = (DimensionalDoors.Components.Game.WeaponInitializeComponent)CreateComponent(index, typeof(DimensionalDoors.Components.Game.WeaponInitializeComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.weapon = newWeapon;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceWeaponInitialize(GameBlueprintBehaviour newWeapon)
	{
		var index = GameComponentsLookup.WeaponInitialize;
		var component = (DimensionalDoors.Components.Game.WeaponInitializeComponent)CreateComponent(index, typeof(DimensionalDoors.Components.Game.WeaponInitializeComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.weapon = newWeapon;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyWeaponInitializeTo(DimensionalDoors.Components.Game.WeaponInitializeComponent copyComponent)
	{
		var index = GameComponentsLookup.WeaponInitialize;
		var component = (DimensionalDoors.Components.Game.WeaponInitializeComponent)CreateComponent(index, typeof(DimensionalDoors.Components.Game.WeaponInitializeComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.weapon = copyComponent.weapon;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveWeaponInitialize()
	{
		RemoveComponent(GameComponentsLookup.WeaponInitialize);
	}
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.4.4.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher
{
	static JCMG.EntitasRedux.IMatcher<GameEntity> _matcherWeaponInitialize;

	public static JCMG.EntitasRedux.IMatcher<GameEntity> WeaponInitialize
	{
		get
		{
			if (_matcherWeaponInitialize == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<GameEntity>)JCMG.EntitasRedux.Matcher<GameEntity>.AllOf(GameComponentsLookup.WeaponInitialize);
				matcher.ComponentNames = GameComponentsLookup.ComponentNames;
				_matcherWeaponInitialize = matcher;
			}

			return _matcherWeaponInitialize;
		}
	}
}