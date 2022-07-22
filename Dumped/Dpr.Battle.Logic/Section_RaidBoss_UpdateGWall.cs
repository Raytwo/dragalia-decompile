using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_RaidBoss_UpdateGWall : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public PokeSet damagedPokeSet;

		public WazaParam wazaParam;
	}

	public class Result
	{
		public SectionUtil.GWallUpdateResult gWallUpdateResult;
	}

	public Section_RaidBoss_UpdateGWall([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private bool decGWallGauge(BTL_POKEPARAM attacker, BTL_POKEPARAM boss, WazaParam wazaParam)
	{
		return default(bool);
	}

	private byte getGWallSubValue(BTL_POKEPARAM attacker, WazaParam wazaParam)
	{
		return default(byte);
	}

	private bool isIchigekiWaza(WazaParam wazaParam)
	{
		return default(bool);
	}
}
