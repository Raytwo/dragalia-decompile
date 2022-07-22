using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class Section_RaidBoss_Angry_AddWazaAction : Section
{
	public class Description
	{
		public DominantPriority dominantPriority;
	}

	public class Result
	{
	}

	public Section_RaidBoss_Angry_AddWazaAction([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private BtlPokePos calcTargetPos(BTL_POKEPARAM boss, WazaNo wazano)
	{
		return default(BtlPokePos);
	}

	private uint calcActionPriority(PokeAction pokeAction, DominantPriority dominantPriority)
	{
		return default(uint);
	}
}
