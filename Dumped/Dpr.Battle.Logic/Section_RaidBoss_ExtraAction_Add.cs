using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_RaidBoss_ExtraAction_Add : Section
{
	public class Description
	{
	}

	public class Result
	{
	}

	public Section_RaidBoss_ExtraAction_Add([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private uint calcActionPriority(PokeAction pokeAction)
	{
		return default(uint);
	}
}
