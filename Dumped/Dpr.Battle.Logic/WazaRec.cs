using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class WazaRec
{
	private class RECORD
	{
		public uint turn;

		public WazaNo wazaID;

		public byte pokeID;

		public bool fEffective;

		public void CopyFrom(RECORD src)
		{
		}
	}

	public const int TURN_MAX = 20;

	public const int RECORD_MAX = 400;

	private uint m_ptr;

	private RECORD[] m_record;

	public void CopyFrom([In] ref WazaRec src)
	{
	}

	public void Init()
	{
	}

	public void Add(WazaNo waza, uint turn, byte pokeID)
	{
	}

	public void SetEffectiveLast()
	{
	}

	public bool IsUsedWaza(WazaNo waza, uint turn)
	{
		return default(bool);
	}

	public uint GetUsedWazaCount(WazaNo waza, uint turn)
	{
		return default(uint);
	}

	public WazaNo GetPrevEffectiveWaza(uint turn)
	{
		return default(WazaNo);
	}
}
