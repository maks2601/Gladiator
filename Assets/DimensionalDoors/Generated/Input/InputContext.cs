//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.4.4.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class InputContext : JCMG.EntitasRedux.Context<InputEntity>
{
	public InputContext()
		: base(
			InputComponentsLookup.TotalComponents,
			0,
			new JCMG.EntitasRedux.ContextInfo(
				"Input",
				InputComponentsLookup.ComponentNames,
				InputComponentsLookup.ComponentTypes
			),
			(entity) =>

#if (ENTITAS_FAST_AND_UNSAFE)
				new JCMG.EntitasRedux.UnsafeAERC(),
#else
				new JCMG.EntitasRedux.SafeAERC(entity),
#endif
			() => new InputEntity()
		)
	{
	}

	/// <summary>
	/// Creates a new entity and adds copies of all specified components to it. If replaceExisting is true, it will
	/// replace existing components.
	/// </summary>
	public InputEntity CloneEntity(InputEntity entity, bool replaceExisting = false, params int[] indices)
	{
		var target = CreateEntity();
		entity.CopyTo(target, replaceExisting, indices);
		return target;
	}
}
