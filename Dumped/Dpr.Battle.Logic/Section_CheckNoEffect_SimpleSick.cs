using System.Runtime.InteropServices;
using Pml;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class Section_CheckNoEffect_SimpleSick : Section
{
	public class Description
	{
		public WazaParam wazaParam;

		public BTL_POKEPARAM attacker;

		public PokeSet targets;
	}

	public class Result
	{
	}

	public Section_CheckNoEffect_SimpleSick([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private bool checkNoEffect(WazaParam wazaParam, BTL_POKEPARAM attacker, PokeSet targets)
	{
		return default(bool);
	}

	private bool isNoEffect(BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaNo waza)
	{
		return default(bool);
	}

	private bool addSickCheckFail(BTL_POKEPARAM target, BTL_POKEPARAM attacker, WazaSick sick, [In] ref BTL_SICKCONT sickCont)
	{
		return default(bool);
	}
}
