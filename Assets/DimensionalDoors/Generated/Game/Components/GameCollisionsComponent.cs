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
	public DimensionalDoors.Components.Game.CollisionsComponent Collisions { get { return (DimensionalDoors.Components.Game.CollisionsComponent)GetComponent(GameComponentsLookup.Collisions); } }
	public bool HasCollisions { get { return HasComponent(GameComponentsLookup.Collisions); } }

	public void AddCollisions(System.Collections.Generic.List<GameEntity> newList)
	{
		var index = GameComponentsLookup.Collisions;
		var component = (DimensionalDoors.Components.Game.CollisionsComponent)CreateComponent(index, typeof(DimensionalDoors.Components.Game.CollisionsComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.list = newList;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceCollisions(System.Collections.Generic.List<GameEntity> newList)
	{
		var index = GameComponentsLookup.Collisions;
		var component = (DimensionalDoors.Components.Game.CollisionsComponent)CreateComponent(index, typeof(DimensionalDoors.Components.Game.CollisionsComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.list = newList;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyCollisionsTo(DimensionalDoors.Components.Game.CollisionsComponent copyComponent)
	{
		var index = GameComponentsLookup.Collisions;
		var component = (DimensionalDoors.Components.Game.CollisionsComponent)CreateComponent(index, typeof(DimensionalDoors.Components.Game.CollisionsComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.list = (System.Collections.Generic.List<GameEntity>)JCMG.EntitasRedux.ListTools.ShallowCopy(copyComponent.list);
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveCollisions()
	{
		RemoveComponent(GameComponentsLookup.Collisions);
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
	static JCMG.EntitasRedux.IMatcher<GameEntity> _matcherCollisions;

	public static JCMG.EntitasRedux.IMatcher<GameEntity> Collisions
	{
		get
		{
			if (_matcherCollisions == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<GameEntity>)JCMG.EntitasRedux.Matcher<GameEntity>.AllOf(GameComponentsLookup.Collisions);
				matcher.ComponentNames = GameComponentsLookup.ComponentNames;
				_matcherCollisions = matcher;
			}

			return _matcherCollisions;
		}
	}
}
