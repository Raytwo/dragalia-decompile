using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_CriticalMsg : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public WazaParam wazaParam;

		public uint targetNum;

		public BTL_POKEPARAM[] targets;

		public CriticalType[] criticalTypes;

		public bool isPluralHitWaza;
	}

	public class Result
	{
	}

	public Section_CriticalMsg([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void putMessage(BTL_POKEPARAM attacker, BTL_POKEPARAM target, CriticalType criticalType, bool isPluralHitWaza)
	{
	}

	private void checkBattleTalk(byte pokeID)
	{
	}
}
