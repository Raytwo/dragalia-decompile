using System.Runtime.InteropServices;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class Section_RankEffect_CheckEffective : Section
{
	public class Description
	{
		public byte attackerID;

		public byte targetID;

		public WazaRankEffect effect;

		public int volume;

		public RankEffectCause cause;

		public ushort itemID;

		public uint rankEffSerial;

		public bool canPutFailMessage;

		public bool canMigawariThrew;

		public SimpleEffectFailManager pSimpleEffectFailManager;
	}

	public class Result
	{
		public bool isValid;
	}

	public Section_RankEffect_CheckEffective([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private bool checkFail_GWall(BTL_POKEPARAM attacker, BTL_POKEPARAM target)
	{
		return default(bool);
	}

	private bool isInvalidByLimit(BTL_POKEPARAM target, WazaRankEffect effect, int volume)
	{
		return default(bool);
	}

	private void putFailMessage_GWall(BTL_POKEPARAM target)
	{
	}

	private void putFailMessage_Limit(BTL_POKEPARAM target, WazaRankEffect effect, int volume)
	{
	}

	private void putFailMessage_Migawari(BTL_POKEPARAM target)
	{
	}
}
