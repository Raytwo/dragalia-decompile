using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class SideEffectStatus
{
	private class DATA
	{
		public BtlSideEffect sideEffect;

		public BTL_SICKCONT contParam;

		public uint turn_counter;

		public uint add_counter;

		public void CopyFrom(DATA src)
		{
		}
	}

	private DATA m_data;

	public SideEffectStatus(BtlSideEffect sideEffect)
	{
	}

	public void CopyFrom([In] ref SideEffectStatus src)
	{
	}

	public void SwapFrom(SideEffectStatus target)
	{
	}

	public bool AddEffect([In] ref BTL_SICKCONT contParam)
	{
		return default(bool);
	}

	public bool RemoveEffect()
	{
		return default(bool);
	}

	public bool IsEffective()
	{
		return default(bool);
	}

	public uint GetAddCount()
	{
		return default(uint);
	}

	public uint GetMaxTurnCount()
	{
		return default(uint);
	}

	public uint GetCurrentTurnCount()
	{
		return default(uint);
	}

	public uint GetRemainingTurn()
	{
		return default(uint);
	}

	public uint GetTurnUpCount()
	{
		return default(uint);
	}

	public byte GetCausePokeID()
	{
		return default(byte);
	}

	public void IncTurnCount()
	{
	}

	public bool IsTurnPassed()
	{
		return default(bool);
	}

	public BTL_SICKCONT GetContParam()
	{
		return default(BTL_SICKCONT);
	}
}
