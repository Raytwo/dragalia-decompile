using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class PosEffectStatus
{
	private class Data
	{
		public BtlPokePos pos;

		public BtlPosEffect posEffect;

		public bool isEffective;

		public PosEffect.EffectParam effectParam;

		public void CopyFrom(Data src)
		{
		}
	}

	private Data m_data;

	public PosEffectStatus(BtlPokePos pos, BtlPosEffect posEffect)
	{
	}

	public void CopyFrom([In] ref PosEffectStatus src)
	{
	}

	public bool SetEffect([In] ref PosEffect.EffectParam effectParam)
	{
		return default(bool);
	}

	public void RemoveEffect()
	{
	}

	public bool IsEffective()
	{
		return default(bool);
	}

	public PosEffect.EffectParam GetEffectParam()
	{
		return default(PosEffect.EffectParam);
	}

	public void SetEffectParam([In] ref PosEffect.EffectParam effectParam)
	{
	}

	public BtlPokePos GetPokePos()
	{
		return default(BtlPokePos);
	}

	public BtlPosEffect GetPosEffect()
	{
		return default(BtlPosEffect);
	}
}
