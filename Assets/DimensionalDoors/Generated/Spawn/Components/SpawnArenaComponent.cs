//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.4.4.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class SpawnEntity
{
	public DimensionalDoors.Components.Spawn.ArenaComponent Arena { get { return (DimensionalDoors.Components.Spawn.ArenaComponent)GetComponent(SpawnComponentsLookup.Arena); } }
	public bool HasArena { get { return HasComponent(SpawnComponentsLookup.Arena); } }

	public void AddArena(int newCurrentArena)
	{
		var index = SpawnComponentsLookup.Arena;
		var component = (DimensionalDoors.Components.Spawn.ArenaComponent)CreateComponent(index, typeof(DimensionalDoors.Components.Spawn.ArenaComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.currentArena = newCurrentArena;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceArena(int newCurrentArena)
	{
		var index = SpawnComponentsLookup.Arena;
		var component = (DimensionalDoors.Components.Spawn.ArenaComponent)CreateComponent(index, typeof(DimensionalDoors.Components.Spawn.ArenaComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.currentArena = newCurrentArena;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyArenaTo(DimensionalDoors.Components.Spawn.ArenaComponent copyComponent)
	{
		var index = SpawnComponentsLookup.Arena;
		var component = (DimensionalDoors.Components.Spawn.ArenaComponent)CreateComponent(index, typeof(DimensionalDoors.Components.Spawn.ArenaComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.currentArena = copyComponent.currentArena;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveArena()
	{
		RemoveComponent(SpawnComponentsLookup.Arena);
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
public sealed partial class SpawnMatcher
{
	static JCMG.EntitasRedux.IMatcher<SpawnEntity> _matcherArena;

	public static JCMG.EntitasRedux.IMatcher<SpawnEntity> Arena
	{
		get
		{
			if (_matcherArena == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<SpawnEntity>)JCMG.EntitasRedux.Matcher<SpawnEntity>.AllOf(SpawnComponentsLookup.Arena);
				matcher.ComponentNames = SpawnComponentsLookup.ComponentNames;
				_matcherArena = matcher;
			}

			return _matcherArena;
		}
	}
}
