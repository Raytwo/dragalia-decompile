using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class PosPoke
{
	private sealed class State
	{
		public bool fEnable;

		public byte clientID;

		public byte existPokeID;

		public void CopyFrom(State src)
		{
		}
	}

	private State[] m_state;

	private BtlPokePos[] m_lastPosInst;

	private BtlPokePos m_lastPosDmy;

	private void setLastPos(int i, BtlPokePos pos)
	{
	}

	private BtlPokePos getLastPos(int i)
	{
		return default(BtlPokePos);
	}

	public void CopyFrom([In] ref PosPoke src)
	{
	}

	public void Init(MainModule mainModule, POKECON pokeCon)
	{
	}

	private void setInitialFrontPokemon(MainModule mainModule, POKECON pokeCon, BtlPokePos pos)
	{
	}

	public void ExtendPos([In] ref MainModule mainModule, BtlPokePos pos)
	{
	}

	public void PokeOut(byte pokeID)
	{
	}

	public void PokeIn(MainModule mainModule, BtlPokePos pos, byte pokeID, POKECON pokeCon)
	{
	}

	private void checkConfrontRec(MainModule mainModule, BtlPokePos pos, POKECON pokeCon)
	{
	}

	public void Swap(BtlPokePos pos1, BtlPokePos pos2)
	{
	}

	private void updateLastPos(BtlPokePos pos)
	{
	}

	public byte GetClientEmptyPos(byte clientID, BtlPokePos[] pos)
	{
		return default(byte);
	}

	public byte GetClientEmptyPosCount(byte clientID)
	{
		return default(byte);
	}

	public bool IsExist(byte pokeID)
	{
		return default(bool);
	}

	public bool IsExistFrontPos(MainModule mainModule, byte pokeID)
	{
		return default(bool);
	}

	public BtlPokePos GetPokeExistPos(byte pokeID)
	{
		return default(BtlPokePos);
	}

	public BtlPokePos GetPokeLastPos(byte pokeID)
	{
		return default(BtlPokePos);
	}

	public byte GetExistPokeID(BtlPokePos pos)
	{
		return default(byte);
	}
}
