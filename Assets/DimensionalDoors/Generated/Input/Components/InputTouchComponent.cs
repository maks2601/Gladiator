//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.4.4.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity
{
	public DimensionalDoors.Components.Input.TouchComponent Touch { get { return (DimensionalDoors.Components.Input.TouchComponent)GetComponent(InputComponentsLookup.Touch); } }
	public bool HasTouch { get { return HasComponent(InputComponentsLookup.Touch); } }

	public void AddTouch(UnityEngine.Vector2 newStartPoint, UnityEngine.Vector2 newEndPoint)
	{
		var index = InputComponentsLookup.Touch;
		var component = (DimensionalDoors.Components.Input.TouchComponent)CreateComponent(index, typeof(DimensionalDoors.Components.Input.TouchComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.startPoint = newStartPoint;
		component.endPoint = newEndPoint;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceTouch(UnityEngine.Vector2 newStartPoint, UnityEngine.Vector2 newEndPoint)
	{
		var index = InputComponentsLookup.Touch;
		var component = (DimensionalDoors.Components.Input.TouchComponent)CreateComponent(index, typeof(DimensionalDoors.Components.Input.TouchComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.startPoint = newStartPoint;
		component.endPoint = newEndPoint;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyTouchTo(DimensionalDoors.Components.Input.TouchComponent copyComponent)
	{
		var index = InputComponentsLookup.Touch;
		var component = (DimensionalDoors.Components.Input.TouchComponent)CreateComponent(index, typeof(DimensionalDoors.Components.Input.TouchComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.startPoint = copyComponent.startPoint;
		component.endPoint = copyComponent.endPoint;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveTouch()
	{
		RemoveComponent(InputComponentsLookup.Touch);
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
public sealed partial class InputMatcher
{
	static JCMG.EntitasRedux.IMatcher<InputEntity> _matcherTouch;

	public static JCMG.EntitasRedux.IMatcher<InputEntity> Touch
	{
		get
		{
			if (_matcherTouch == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<InputEntity>)JCMG.EntitasRedux.Matcher<InputEntity>.AllOf(InputComponentsLookup.Touch);
				matcher.ComponentNames = InputComponentsLookup.ComponentNames;
				_matcherTouch = matcher;
			}

			return _matcherTouch;
		}
	}
}
