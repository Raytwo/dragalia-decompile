using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaExec_CombiWazaReady : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public WazaNo waza;

		public BtlPokePos targetPos;
	}

	public class Result
	{
		public bool isReadied;
	}

	private const uint MAX_COMBI_POKE_NUM = 4u;

	private static readonly WazaNo[] COMBI_WAZA_TABLE;

	public Section_WazaExec_CombiWazaReady([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private bool isCombiWaza(WazaNo waza)
	{
		return default(bool);
	}

	private void getCombiPossibleActions(PokeAction[] ppActionBuffer, ref uint pActionNum, byte attackerID, WazaNo waza, BtlPokePos targetPos)
	{
	}

	private PokeAction getCombiPartnerAction(PokeAction[] pActions, uint actionNum)
	{
		return null;
	}
}
