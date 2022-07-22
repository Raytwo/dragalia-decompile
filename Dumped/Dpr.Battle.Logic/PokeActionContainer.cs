using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class PokeActionContainer
{
	private const byte MAX_ACT_ORDER_NUM = 30;

	private PokeAction[] m_actions;

	private byte m_count;

	public void Clear()
	{
	}

	public byte GetCount()
	{
		return default(byte);
	}

	public byte GetIndex(PokeAction action)
	{
		return default(byte);
	}

	public bool IsAllActDoneByPokeID(byte pokeID)
	{
		return default(bool);
	}

	public void Add([In] ref PokeAction action)
	{
	}

	public bool IsAllActionDone()
	{
		return default(bool);
	}

	public PokeAction Next()
	{
		return null;
	}

	public PokeAction Get(byte index)
	{
		return null;
	}

	public void Swap(byte index1, byte index2)
	{
	}

	public void ForceDone(byte pokeID)
	{
	}

	public PokeAction SearchByPokeID(byte pokeID, bool isSkipGStart, bool isSkipNull = false)
	{
		return null;
	}

	public PokeAction SearchNextByPokeID(PokeAction start, byte pokeID, bool isSkipGStart)
	{
		return null;
	}

	private PokeAction searchByPokeID_Core(byte pokeID, byte startIdx, bool isSkipGStart, bool isSkipNull = false, bool isSkipDone = false, WazaNo wazano = WazaNo.NULL)
	{
		return null;
	}

	public PokeAction SearchByWazaID(WazaNo waza, byte startIndex)
	{
		return null;
	}

	public PokeAction SearchForCombiWaza(MainModule pMainModule, WazaNo waza, byte pokeID, BtlPokePos targetPos)
	{
		return null;
	}

	public bool PostponeAction(byte pokeID)
	{
		return default(bool);
	}

	public void PostponeAction(PokeAction action)
	{
	}

	public void InterruptAction(PokeAction action)
	{
	}

	public bool ReserveInterruptAction(byte intrPokeID, WazaNo wazano = WazaNo.NULL)
	{
		return default(bool);
	}

	public bool ReserveInterruptActionByWaza(WazaNo waza)
	{
		return default(bool);
	}

	public bool InsertAction([In] ref PokeAction action)
	{
		return default(bool);
	}
}
