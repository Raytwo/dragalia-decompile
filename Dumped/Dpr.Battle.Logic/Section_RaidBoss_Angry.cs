using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_RaidBoss_Angry : Section
{
	public class Description
	{
		public bool canPutMessage;

		public bool canInsertWazaAction;
	}

	public class Result
	{
	}

	public Section_RaidBoss_Angry([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private bool checkAngry(BTL_POKEPARAM boss)
	{
		return default(bool);
	}

	private bool checkWazaActionEnable(BTL_POKEPARAM boss)
	{
		return default(bool);
	}

	private void addWazaAction()
	{
	}

	private void appearGWall(BTL_POKEPARAM boss)
	{
	}
}
