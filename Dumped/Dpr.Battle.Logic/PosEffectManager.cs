using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class PosEffectManager
{
	private PosEffectStatus[][] m_posEffects;

	public void CreateEffectStatusArray()
	{
	}

	private void DeleteEffectStatusArray()
	{
	}

	public void CopyFrom([In] ref PosEffectManager src)
	{
	}

	public void RemoveAllPosEffect()
	{
	}

	public PosEffectStatus GetPosEffectStatus(BtlPokePos pos, BtlPosEffect effect)
	{
		return null;
	}

	public PosEffectStatus GetPosEffectStatusConst(BtlPokePos pos, BtlPosEffect effect)
	{
		return null;
	}
}
