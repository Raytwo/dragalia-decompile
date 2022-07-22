using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class ExPokePos
{
	public enum ExPosType
	{
		BASE_POS,
		NEXT_FRIENDS,
		AREA_ENEMY,
		AREA_OTHERS,
		AREA_MYTEAM,
		AREA_FRIENDS,
		AREA_ALL,
		FULL_ENEMY,
		FULL_FRIENDS,
		FULL_ALL
	}

	private class ExpandResult
	{
		public BtlPokePos[] pos;

		public byte count;

		public void Add(BtlPokePos addPos)
		{
		}
	}

	private ExPosType m_type;

	private BtlPokePos m_basePos;

	public ExPokePos()
	{
	}

	public ExPokePos(ExPosType type, BtlPokePos basePos)
	{
	}

	public ExPokePos([In] ref ExPokePos src)
	{
	}

	public ExPokePos CopyFrom([In] ref ExPokePos rhl)
	{
		return null;
	}

	public byte ExpandPos(BtlRule rule, BtlMultiMode multiMode, BtlPokePos[] dst)
	{
		return default(byte);
	}

	private void expandPos_single(ExpandResult result, BtlMultiMode multiMode)
	{
	}

	private void expandPokePos_double(ExpandResult result, BtlMultiMode multiMode)
	{
	}

	private void expandPokePos_raid(ExpandResult result, BtlMultiMode multiMode)
	{
	}

	public byte ExpandExistPokeID(BtlRule rule, BtlMultiMode multiMode, POKECON pokeCon, byte[] pokeIDAry)
	{
		return default(byte);
	}
}
