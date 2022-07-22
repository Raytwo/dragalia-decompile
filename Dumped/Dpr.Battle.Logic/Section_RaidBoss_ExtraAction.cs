using System.Runtime.InteropServices;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class Section_RaidBoss_ExtraAction : Section
{
	public class Description
	{
	}

	public class Result
	{
	}

	public Section_RaidBoss_ExtraAction([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private bool canExtraAttack()
	{
		return default(bool);
	}

	private void effectOnExtraAttack()
	{
	}

	private void rankUp()
	{
	}

	private void rankUp(WazaRankEffect effect)
	{
	}

	private void extraAttack()
	{
	}

	private void decideWazaParam(WazaParam pWazaParam)
	{
	}

	private BTL_POKEPARAM decideTarget([In] ref WazaParam wazaParam)
	{
		return null;
	}

	private void wazaExec(BTL_POKEPARAM target, WazaParam wazaParam)
	{
	}

	private void initGWall()
	{
	}

	private void repairGWall()
	{
	}

	private BTL_POKEPARAM getBoss()
	{
		return null;
	}
}
