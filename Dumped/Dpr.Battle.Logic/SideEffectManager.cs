using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class SideEffectManager
{
	private SideEffectStatus[][] m_sideEffects;

	public void CreateEffectStatusArray()
	{
	}

	private void DeleteEffectStatusArray()
	{
	}

	public void CopyFrom([In] ref SideEffectManager src)
	{
	}

	public void RemoveAllSideEffect()
	{
	}

	public bool SwapSideEffect(BtlSide side1, BtlSide side2, BtlSideEffect effect)
	{
		return default(bool);
	}

	public SideEffectStatus GetSideEffectStatus(BtlSide side, BtlSideEffect effect)
	{
		return null;
	}

	public SideEffectStatus GetSideEffectStatusConst(BtlSide side, BtlSideEffect effect)
	{
		return null;
	}
}
