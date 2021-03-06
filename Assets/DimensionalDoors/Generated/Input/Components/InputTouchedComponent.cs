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
	static readonly DimensionalDoors.Components.Input.Touched TouchedComponent = new DimensionalDoors.Components.Input.Touched();

	public bool IsTouched
	{
		get { return HasComponent(InputComponentsLookup.Touched); }
		set
		{
			if (value != IsTouched)
			{
				var index = InputComponentsLookup.Touched;
				if (value)
				{
					var componentPool = GetComponentPool(index);
					var component = componentPool.Count > 0
							? componentPool.Pop()
							: TouchedComponent;

					AddComponent(index, component);
				}
				else
				{
					RemoveComponent(index);
				}
			}
		}
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
	static JCMG.EntitasRedux.IMatcher<InputEntity> _matcherTouched;

	public static JCMG.EntitasRedux.IMatcher<InputEntity> Touched
	{
		get
		{
			if (_matcherTouched == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<InputEntity>)JCMG.EntitasRedux.Matcher<InputEntity>.AllOf(InputComponentsLookup.Touched);
				matcher.ComponentNames = InputComponentsLookup.ComponentNames;
				_matcherTouched = matcher;
			}

			return _matcherTouched;
		}
	}
}
